﻿using System;
using System.Linq.Expressions;
using MvcCoreBootstrap.Building;
using MvcCoreBootstrapForm.Config;

namespace MvcCoreBootstrapForm.Builders
{
    public class MvcCoreBootstrapRadioButtonsBuilder<TModel, TResult> : BuilderBase
    {
        private readonly RadioButtonsConfig<TModel, TResult> _config;
        private readonly Expression<Func<TModel, TResult>> _expression;

        internal MvcCoreBootstrapRadioButtonsBuilder(RadioButtonsConfig<TModel, TResult> config,
            Expression<Func<TModel, TResult>> expression)
        {
            _config = config;
            _expression = expression;
        }

        /// <summary>
        /// Renders the radio buttons horizontally instead of vertically.
        /// </summary>
        /// <returns>The radion buttons builder instance.</returns>
        public MvcCoreBootstrapRadioButtonsBuilder<TModel, TResult> Horizontal()
        {
            return(this.SetConfigProp<MvcCoreBootstrapRadioButtonsBuilder<TModel, TResult>>(() => _config.Horizontal = true));
        }

        /// <summary>
        /// Configures a radio button.
        /// </summary>
        /// <param name="value">Radio button value.</param>
        /// <param name="configAction">Action that implements radio button configuration.</param>
        /// <returns>The radion buttons builder instance.</returns>
        public MvcCoreBootstrapRadioButtonsBuilder<TModel, TResult> RadioButton(object value,
            Action<MvcCoreBootstrapRadioButtonBuilder> configAction = null)
        {
            RadioButtonConfig<TModel, TResult> config = new RadioButtonConfig<TModel, TResult>
            {
                Value = value, Expression = _expression
            };
            MvcCoreBootstrapRadioButtonBuilder builder = new MvcCoreBootstrapRadioButtonBuilder(config);

            configAction?.Invoke(builder);
            _config.RadioButtons.Add(config);

            return(this);
        }
    }
}