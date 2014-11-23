﻿using System;
using System.Collections.Immutable;

using NQuery.Authoring.CodeActions;

namespace NQuery.Authoring.UnitTests.CodeActions
{
    public abstract class RefactoringTests : CodeActionTest
    {
        protected override ImmutableArray<ICodeAction> GetActions(string query)
        {
            int position;
            var compilation = CompilationFactory.CreateQuery(query, out position);
            var semanticModel = compilation.GetSemanticModel();

            var provider = CreateProvider();
            var providers = new[] {provider};
            return semanticModel.GetRefactorings(position, providers).ToImmutableArray();
        }

        protected abstract ICodeRefactoringProvider CreateProvider();
    }
}