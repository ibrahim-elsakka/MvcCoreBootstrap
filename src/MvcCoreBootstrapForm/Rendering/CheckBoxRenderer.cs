﻿using System;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcCoreBootstrapForm.Config;

namespace MvcCoreBootstrapForm.Rendering
{
    internal class CheckBoxRenderer<TModel> : ControlRenderer<TModel, bool>
    {
        public IHtmlContent Render(CheckBoxConfig config, IHtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, bool>> expression)
        {
            TagBuilder container = config.Inline ? null : new TagBuilder("div");
            TagBuilder label = new TagBuilder("label");
            TagBuilder checkBox = this.TagBuilderFromHtmlContent(htmlHelper.CheckBoxFor(expression, null), false);

            if(container != null)
            {
                if(config.Disabled)
                {
                    container.AddCssClass("disabled");
                    checkBox.Attributes.Add("disabled", null);
                }
                container.AddCssClass("checkbox");
                container.InnerHtml.AppendHtml(label);
            }
            label.InnerHtml.AppendHtml(checkBox);
            if(config.Inline)
            {
                label.AddCssClass("checkbox-inline");
            }
            if(!string.IsNullOrEmpty(config.Label))
            {
                label.InnerHtml.Append(config.Label);
            }
            else if(config.AutoLabel)
            {
                TagBuilder autoLabel = this.TagBuilderFromHtmlContent(htmlHelper.LabelFor(expression, null, null), false);

                label.InnerHtml.AppendHtml(autoLabel.InnerHtml);
            }
            this.AddCssClasses(container, config.CssClasses);

            return(container ?? label);
        }
    }
}