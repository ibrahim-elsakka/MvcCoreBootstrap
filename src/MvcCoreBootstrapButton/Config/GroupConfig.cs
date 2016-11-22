﻿using System.Collections.Generic;
using MvcCoreBootstrap;

namespace MvcCoreBootstrapButton.Config
{
    internal class GroupConfig
    {
        public GroupConfig()
        {
            Buttons = new List<ButtonConfig>();
            ButtonSize = MvcCoreBootstrapButtonSize.Default;
            State = ContextualState.Default;
        }

        public IList<ButtonConfig> Buttons { get; set; }
        public IList<GroupConfig> Groups { get; set; }
        public bool Vertical { get; set; }
        public MvcCoreBootstrapButtonSize ButtonSize { get; set; }
        public ContextualState State { get; set; }
    }
}
