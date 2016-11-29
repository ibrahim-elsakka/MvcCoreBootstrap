﻿using MvcCoreBootstrap.Building;
using MvcCoreBootstrapForm.Config;

namespace MvcCoreBootstrapForm.Builders
{
    public class MvcCoreBootstrapTextAreaBuilder : BuilderBase
    {
        private readonly TextAreaConfig _config;

        internal MvcCoreBootstrapTextAreaBuilder(TextAreaConfig config)
        {
            _config = config;
        }

        /// <summary>
        /// Sets the id attribute for the text area.
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>The text area builder instance.</returns>
        public MvcCoreBootstrapTextAreaBuilder Id(string id)
        {
            return(this.SetConfigProp<MvcCoreBootstrapTextAreaBuilder>(() => _config.Id = id));
        }

        /// <summary>
        /// Sets the name attribute for the text area.
        /// </summary>
        /// <param name="name">Name</param>
        /// <returns>The text area builder instance.</returns>
        public MvcCoreBootstrapTextAreaBuilder Name(string name)
        {
            return(this.SetConfigProp<MvcCoreBootstrapTextAreaBuilder>(() => _config.Name = name));
        }

        /// <summary>
        /// Do not generate a label automatically for the text input.
        /// </summary>
        /// <returns>The text input builder instance.</returns>
        public MvcCoreBootstrapTextAreaBuilder NoLabel()
        {
            return(this.SetConfigProp<MvcCoreBootstrapTextAreaBuilder>(() => _config.AutoLabel = false));
        }

        /// <summary>
        /// Sets the label for the text input.
        /// </summary>
        /// <param name="label">Text input label.</param>
        /// <returns>The text input builder instance.</returns>
        public MvcCoreBootstrapTextAreaBuilder Label(string label)
        {
            return(this.SetConfigProp<MvcCoreBootstrapTextAreaBuilder>(() => _config.Label = label));
        }

        /// <summary>
        /// Sets the disabled state for the text input.
        /// </summary>
        /// <param name="disabled">If true, the text input is disabled</param>
        /// <returns>The text input builder instance.</returns>
        public MvcCoreBootstrapTextInputBuilder Disabled(bool disabled = true)
        {
            return(this.SetConfigProp<MvcCoreBootstrapTextInputBuilder>(() => _config.Disabled = disabled));
        }

        /// <summary>
        /// Sets a css class for the text area element.
        /// </summary>
        /// <param name="cssClass">Name of css class.</param>
        /// <param name="condition">If true, the css class will be set for the text area element.</param>
        /// <returns>The text area builder instance.</returns>
        public MvcCoreBootstrapTextAreaBuilder CssClass(string cssClass, bool condition = true)
        {
            return(this.AddCssClass<MvcCoreBootstrapTextAreaBuilder>(_config.CssClasses, cssClass, condition));
        }
    }
}