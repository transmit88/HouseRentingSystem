﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Data;

namespace HouseRentingSystem.ModelBinders
{
    public class DecimalModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder? GetBinder(ModelBinderProviderContext context)
        {
            if (context == null)
            {
                throw new ArgumentException(nameof(context));
            }

            if (context.Metadata.ModelType == typeof(Decimal) || context.Metadata.ModelType == typeof(Decimal?))
            {
                return new DecimalModelBinder();
            }

            return null;
        }
    }
}
