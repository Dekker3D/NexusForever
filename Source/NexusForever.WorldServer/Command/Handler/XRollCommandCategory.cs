﻿using NexusForever.WorldServer.Command.Context;
using NexusForever.WorldServer.Command.Static;
using NexusForever.WorldServer.Game.Entity;
using NexusForever.WorldServer.Game.Map.Search;
using NexusForever.WorldServer.Game.RBAC.Static;
using NexusForever.WorldServer.Game.Social;
using NexusForever.WorldServer.Network.Message.Model;
using System;
using System.Collections.Generic;

namespace NexusForever.WorldServer.Command.Handler
{
    [Command(Permission.XRoll, "An extended /roll", "xroll")]
    public class XRollCommandCategory : CommandCategory
    {
        private const float LocalChatDistance = 175f;
        /// <summary>
        /// Invoke <see cref="CommandCategory"/> with the supplied <see cref="ICommandContext"/> and <see cref="ParameterQueue"/>.
        /// </summary>
        public override CommandResult Invoke(ICommandContext context, ParameterQueue queue)
        {
            CommandResult result = CanInvoke(context); // check permissions.
            if (result != CommandResult.Ok)
                return result;

            if(queue.Count <= 0)
            {
                context.SendError("Invalid parameters - must be formatted as ( XdY Z ), where X=quantity; Y=sides; Z=modifier (optional, can be blank)");
                return CommandResult.InvalidParameters;
            }

            string dice = queue.Dequeue();

            if(!dice.Contains("d"))
            {
                context.SendError("Invalid parameters - must be formatted as ( XdY Z ), where X=quantity; Y=sides; Z=modifier (optional, can be blank)");
                return CommandResult.InvalidParameters;
            }

            int numDice = 1;

            int index = dice.IndexOf("d");
            if(index > 0)
            {
                if(!int.TryParse(dice.Substring(0, index), out numDice))
                {
                    context.SendError("Invalid number of dice - must be formatted as ( XdY Z ), where X=quantity; Y=sides; Z=modifier (optional, can be blank)");
                    return CommandResult.InvalidParameters;
                }
            }

            if(!int.TryParse(dice.Substring(index + 1), out int dieType)) {
                context.SendError("Invalid number of dice - must be formatted as ( XdY Z ), where X=quantity; Y=sides; Z=modifier (optional, can be blank)");
                return CommandResult.InvalidParameters;
            }

            int modifier = 0;
            if (queue.Front != null)
            {
                string modifierString = queue.Dequeue();
                int.TryParse(modifierString, out modifier);
            }

            string modifierText = "";
            if (modifier > 0)
            {
                modifierText = $"+{modifier}";
            }
            if (modifier < 0)
            {
                modifierText = $"{modifier}";
            }

            Random rnd = new Random();

            string numString = "";
            int num = modifier;
            for(int i = 0; i < numDice; ++i)
            {
                int r = rnd.Next(1, dieType);
                num += r;
                numString += $"{((i > 0) ? "+" : "")}{r}";
            }
            string feedback = $"{numDice}d{dieType}{modifierText}: ({numString}){modifierText} = {num}";
            context.SendMessage($"You roll {feedback}");

            Player player = context.GetTargetOrInvoker<Player>();

            // get players in local chat range
            player.Map.Search(
                player.Position,
                LocalChatDistance,
                new SearchCheckRangePlayerOnly(player.Position, LocalChatDistance, player),
                out List<GridEntity> intersectedEntities
            );

            string systemMessage = $"{player.Name} rolls {feedback}";
            intersectedEntities.ForEach(e => ((Player)e).SendSystemMessage(systemMessage));

            return CommandResult.Ok;
        }
    }
}