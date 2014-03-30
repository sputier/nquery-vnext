﻿using System;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using NQuery.Authoring.Completion;
using NQuery.Authoring.Completion.Providers;
using NQuery.Text;

namespace NQuery.Authoring.UnitTests.Completion.Providers
{
    [TestClass]
    public class JoinCompletionProviderTests
    {
        private static void AssertIsMatch(string queryWithJoinMarker)
        {
            var normalized = queryWithJoinMarker.NormalizeCode();

            TextSpan span;
            var queryWithJoin = normalized.ParseSingleSpan(out span);
            var condition = queryWithJoin.Substring(span);
            var query = queryWithJoin.Remove(span.Start, span.Length);
            var position = span.Start;

            var compilation = CompilationFactory.CreateQuery(query);
            var semanticModel = compilation.GetSemanticModel();

            var provider = new JoinCompletionProvider();
            var providers = new[] {provider};

            var completionModel = semanticModel.GetCompletionModel(position, providers);
            var item = completionModel.Items.Single(i => i.InsertionText == condition);

            Assert.AreEqual(NQueryGlyph.Relation, item.Glyph);
            Assert.AreEqual(condition, item.Description);
            Assert.AreEqual(condition, item.DisplayText);
            Assert.AreEqual(condition, item.InsertionText);
            Assert.AreEqual(null, item.Symbol);
        }

        [TestMethod]
        public void JoinCompletionProvider_ReturnsJoin()
        {
            var query = @"
                SELECT  *
                FROM    Employees e
                            INNER JOIN EmployeeTerritories et ON {et.EmployeeID = e.EmployeeID}
            ";

            AssertIsMatch(query);
        }

        [TestMethod]
        public void JoinCompletionProvider_CorrectlyEscapes()
        {
            var query = @"
                SELECT  *
                FROM    Orders o
                            INNER JOIN [Order Details] ON {[Order Details].OrderID = o.OrderID}
            ";

            AssertIsMatch(query);
        }
    }
}