﻿using Microsoft.CodeAnalysis;

namespace Csla.Analyzers.Extensions
{
  internal static class IMethodSymbolExtensions
  {
    internal static bool IsPropertyInfoManagementMethod(this IMethodSymbol @this)
    {
      return @this != null && (@this.ContainingType.Name == CslaMemberConstants.Types.BusinessBase &&
        (@this.Name == CslaMemberConstants.Properties.GetProperty ||
        @this.Name == CslaMemberConstants.Properties.GetPropertyConvert ||
        @this.Name == CslaMemberConstants.Properties.ReadProperty ||
        @this.Name == CslaMemberConstants.Properties.ReadPropertyConvert ||
        @this.Name == CslaMemberConstants.Properties.LazyGetProperty ||
        @this.Name == CslaMemberConstants.Properties.LazyGetPropertyAsync ||
        @this.Name == CslaMemberConstants.Properties.LazyReadProperty ||
        @this.Name == CslaMemberConstants.Properties.LazyReadPropertyAsync ||
        @this.Name == CslaMemberConstants.Properties.LoadProperty ||
        @this.Name == CslaMemberConstants.Properties.LoadPropertyAsync ||
        @this.Name == CslaMemberConstants.Properties.LoadPropertyConvert ||
        @this.Name == CslaMemberConstants.Properties.SetProperty ||
        @this.Name == CslaMemberConstants.Properties.SetPropertyConvert));
    }

    internal static bool IsDataPortalOperation(this IMethodSymbol @this)
    {
      return @this != null && (@this.Name == CslaMemberConstants.Operations.DataPortalCreate || 
        @this.Name == CslaMemberConstants.Operations.DataPortalFetch ||
        @this.Name == CslaMemberConstants.Operations.DataPortalInsert || 
        @this.Name == CslaMemberConstants.Operations.DataPortalUpdate ||
        @this.Name == CslaMemberConstants.Operations.DataPortalDelete || 
        @this.Name == CslaMemberConstants.Operations.DataPortalDeleteSelf ||
        @this.Name == CslaMemberConstants.Operations.DataPortalExecute ||
        @this.Name == CslaMemberConstants.Operations.ChildCreate || 
        @this.Name == CslaMemberConstants.Operations.ChildFetch ||
        @this.Name == CslaMemberConstants.Operations.ChildInsert || 
        @this.Name == CslaMemberConstants.Operations.ChildUpdate ||
        @this.Name == CslaMemberConstants.Operations.ChildDeleteSelf);
    }
  }
}
