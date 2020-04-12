﻿using Umbraco.Core.Composing;

namespace Our.Umbraco.DocTypeGridEditor.ValueProcessing.Collections
{
    /// <summary>
    /// Collection builder for Value Processors <see cref="IDocTypeGridEditorValueProcessor"/>
    /// </summary>
    public class DocTypeGridEditorValueProcessorsCollectionBuilder : OrderedCollectionBuilderBase<DocTypeGridEditorValueProcessorsCollectionBuilder, DocTypeGridEditorValueProcessorsCollection, IDocTypeGridEditorValueProcessor>
    {
        protected override DocTypeGridEditorValueProcessorsCollectionBuilder This => this;
    }
}