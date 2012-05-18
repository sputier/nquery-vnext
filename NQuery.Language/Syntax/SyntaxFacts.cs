using System;
using System.Collections.Generic;
using System.Linq;

namespace NQuery.Language
{
    public static class SyntaxFacts
    {
        public static bool IsLiteral(this SyntaxKind kind)
        {
            return kind == SyntaxKind.DateLiteralToken ||
                   kind == SyntaxKind.NumericLiteralToken ||
                   kind == SyntaxKind.StringLiteralToken;
        }

        public static bool IsComment(this SyntaxKind kind)
        {
            return kind == SyntaxKind.SingleLineCommentTrivia ||
                   kind == SyntaxKind.MultiLineCommentTrivia;
        }

        public static IEnumerable<SyntaxKind> GetKeywordKinds()
        {
            return GetReservedKeywordKinds().Concat(GetContextualKeywordKinds());
        }

        public static IEnumerable<SyntaxKind> GetReservedKeywordKinds()
        {
            yield return SyntaxKind.AndKeyword;
            yield return SyntaxKind.OrKeyword;
            yield return SyntaxKind.IsKeyword;
            yield return SyntaxKind.NullKeyword;
            yield return SyntaxKind.NotKeyword;
            yield return SyntaxKind.LikeKeyword;
            yield return SyntaxKind.SoundslikeKeyword;
            yield return SyntaxKind.SimilarKeyword;
            yield return SyntaxKind.BetweenKeyword;
            yield return SyntaxKind.InKeyword;
            yield return SyntaxKind.CastKeyword;
            yield return SyntaxKind.AsKeyword;
            yield return SyntaxKind.CoalesceKeyword;
            yield return SyntaxKind.NullIfKeyword;
            yield return SyntaxKind.CaseKeyword;
            yield return SyntaxKind.WhenKeyword;
            yield return SyntaxKind.ThenKeyword;
            yield return SyntaxKind.ElseKeyword;
            yield return SyntaxKind.EndKeyword;
            yield return SyntaxKind.TrueKeyword;
            yield return SyntaxKind.FalseKeyword;
            yield return SyntaxKind.ToKeyword;
        }

        public static IEnumerable<SyntaxKind> GetContextualKeywordKinds()
        {
            yield return SyntaxKind.SelectKeyword;
            yield return SyntaxKind.TopKeyword;
            yield return SyntaxKind.DistinctKeyword;
            yield return SyntaxKind.FromKeyword;
            yield return SyntaxKind.WhereKeyword;
            yield return SyntaxKind.GroupKeyword;
            yield return SyntaxKind.ByKeyword;
            yield return SyntaxKind.HavingKeyword;
            yield return SyntaxKind.OrderKeyword;
            yield return SyntaxKind.AscKeyword;
            yield return SyntaxKind.DescKeyword;
            yield return SyntaxKind.UnionKeyword;
            yield return SyntaxKind.AllKeyword;
            yield return SyntaxKind.IntersectKeyword;
            yield return SyntaxKind.ExceptKeyword;
            yield return SyntaxKind.ExistsKeyword;
            yield return SyntaxKind.AnyKeyword;
            yield return SyntaxKind.SomeKeyword;
            yield return SyntaxKind.JoinKeyword;
            yield return SyntaxKind.InnerKeyword;
            yield return SyntaxKind.CrossKeyword;
            yield return SyntaxKind.LeftKeyword;
            yield return SyntaxKind.RightKeyword;
            yield return SyntaxKind.OuterKeyword;
            yield return SyntaxKind.FullKeyword;
            yield return SyntaxKind.OnKeyword;
            yield return SyntaxKind.WithKeyword;
            yield return SyntaxKind.TiesKeyword;
        }

        public static string GetText(SyntaxKind kind)
        {
            switch (kind)
            {
                case SyntaxKind.BitwiseNotToken:
                    return "~";
                case SyntaxKind.BitwiseAndToken:
                    return "&";
                case SyntaxKind.BitwiseOrToken:
                    return "|";
                case SyntaxKind.BitwiseXorToken:
                    return "^";
                case SyntaxKind.LeftParenthesesToken:
                    return "(";
                case SyntaxKind.RightParenthesesToken:
                    return ")";
                case SyntaxKind.PlusToken:
                    return "+";
                case SyntaxKind.MinusToken:
                    return "-";
                case SyntaxKind.MultiplyToken:
                    return "*";
                case SyntaxKind.DivideToken:
                    return "/";
                case SyntaxKind.ModulusToken:
                    return "%";
                case SyntaxKind.PowerToken:
                    return "**";
                case SyntaxKind.CommaToken:
                    return ",";
                case SyntaxKind.DotToken:
                    return ".";
                case SyntaxKind.EqualsToken:
                    return "=";
                case SyntaxKind.UnequalsToken:
                    return "<>";
                case SyntaxKind.LessToken:
                    return "<";
                case SyntaxKind.LessOrEqualToken:
                    return "<=";
                case SyntaxKind.GreaterToken:
                    return ">";
                case SyntaxKind.GreaterOrEqualToken:
                    return ">=";
                case SyntaxKind.NotLessToken:
                    return "!<";
                case SyntaxKind.NotGreaterToken:
                    return "!>";
                case SyntaxKind.LeftShiftToken:
                    return "<<";
                case SyntaxKind.RightShiftToken:
                    return ">>";
                case SyntaxKind.AndKeyword:
                    return "AND";
                case SyntaxKind.OrKeyword:
                    return "OR";
                case SyntaxKind.IsKeyword:
                    return "IS";
                case SyntaxKind.NullKeyword:
                    return "NULL";
                case SyntaxKind.NotKeyword:
                    return "NOT";
                case SyntaxKind.LikeKeyword:
                    return "LIKE";
                case SyntaxKind.SoundslikeKeyword:
                    return "SOUNDSLIKE";
                case SyntaxKind.SimilarKeyword:
                    return "SIMILAR";
                case SyntaxKind.ToKeyword:
                    return "TO";
                case SyntaxKind.BetweenKeyword:
                    return "BETWEEN";
                case SyntaxKind.InKeyword:
                    return "IN";
                case SyntaxKind.CastKeyword:
                    return "CAST";
                case SyntaxKind.AsKeyword:
                    return "AS";
                case SyntaxKind.CoalesceKeyword:
                    return "COALESCE";
                case SyntaxKind.NullIfKeyword:
                    return "NULLIF";
                case SyntaxKind.CaseKeyword:
                    return "CASE";
                case SyntaxKind.WhenKeyword:
                    return "WHEN";
                case SyntaxKind.ThenKeyword:
                    return "THEN";
                case SyntaxKind.ElseKeyword:
                    return "ELSE";
                case SyntaxKind.EndKeyword:
                    return "END";
                case SyntaxKind.TrueKeyword:
                    return "TRUE";
                case SyntaxKind.FalseKeyword:
                    return "FALSE";
                case SyntaxKind.SelectKeyword:
                    return "SELECT";
                case SyntaxKind.TopKeyword:
                    return "TOP";
                case SyntaxKind.DistinctKeyword:
                    return "DISTINCT";
                case SyntaxKind.FromKeyword:
                    return "FROM";
                case SyntaxKind.WhereKeyword:
                    return "WHERE";
                case SyntaxKind.GroupKeyword:
                    return "GROUP";
                case SyntaxKind.ByKeyword:
                    return "BY";
                case SyntaxKind.HavingKeyword:
                    return "HAVING";
                case SyntaxKind.OrderKeyword:
                    return "ORDER";
                case SyntaxKind.AscKeyword:
                    return "ASC";
                case SyntaxKind.DescKeyword:
                    return "DESC";
                case SyntaxKind.UnionKeyword:
                    return "UNION";
                case SyntaxKind.AllKeyword:
                    return "ALL";
                case SyntaxKind.IntersectKeyword:
                    return "INTERSECT";
                case SyntaxKind.ExceptKeyword:
                    return "EXCEPT";
                case SyntaxKind.ExistsKeyword:
                    return "EXISTS";
                case SyntaxKind.AnyKeyword:
                    return "ANY";
                case SyntaxKind.SomeKeyword:
                    return "SOME";
                case SyntaxKind.JoinKeyword:
                    return "JOIN";
                case SyntaxKind.InnerKeyword:
                    return "INNER";
                case SyntaxKind.CrossKeyword:
                    return "CROSS";
                case SyntaxKind.LeftKeyword:
                    return "LEFT";
                case SyntaxKind.RightKeyword:
                    return "RIGHT";
                case SyntaxKind.OuterKeyword:
                    return "OUTER";
                case SyntaxKind.FullKeyword:
                    return "FULL";
                case SyntaxKind.OnKeyword:
                    return "ON";
                case SyntaxKind.WithKeyword:
                    return "WITH";
                case SyntaxKind.TiesKeyword:
                    return "TIES";
                default:
                    return String.Empty;
            }
        }

        public static bool IsIdentifierOrKeyword(this SyntaxKind kind)
        {
            return kind == SyntaxKind.IdentifierToken || kind.IsKeyword();
        }

        public static bool IsKeyword(this SyntaxKind kind)
        {
            switch (kind)
            {
                // Keywords

                case SyntaxKind.AndKeyword:
                case SyntaxKind.OrKeyword:
                case SyntaxKind.IsKeyword:
                case SyntaxKind.NullKeyword:
                case SyntaxKind.NotKeyword:
                case SyntaxKind.LikeKeyword:
                case SyntaxKind.SoundslikeKeyword:
                case SyntaxKind.SimilarKeyword:
                case SyntaxKind.BetweenKeyword:
                case SyntaxKind.InKeyword:
                case SyntaxKind.CastKeyword:
                case SyntaxKind.AsKeyword:
                case SyntaxKind.CoalesceKeyword:
                case SyntaxKind.NullIfKeyword:
                case SyntaxKind.CaseKeyword:
                case SyntaxKind.WhenKeyword:
                case SyntaxKind.ThenKeyword:
                case SyntaxKind.ElseKeyword:
                case SyntaxKind.EndKeyword:
                case SyntaxKind.TrueKeyword:
                case SyntaxKind.FalseKeyword:
                case SyntaxKind.ToKeyword:

                // Contextual keywords

                case SyntaxKind.SelectKeyword:
                case SyntaxKind.TopKeyword:
                case SyntaxKind.DistinctKeyword:
                case SyntaxKind.FromKeyword:
                case SyntaxKind.WhereKeyword:
                case SyntaxKind.GroupKeyword:
                case SyntaxKind.ByKeyword:
                case SyntaxKind.HavingKeyword:
                case SyntaxKind.OrderKeyword:
                case SyntaxKind.AscKeyword:
                case SyntaxKind.DescKeyword:
                case SyntaxKind.UnionKeyword:
                case SyntaxKind.AllKeyword:
                case SyntaxKind.IntersectKeyword:
                case SyntaxKind.ExceptKeyword:
                case SyntaxKind.ExistsKeyword:
                case SyntaxKind.AnyKeyword:
                case SyntaxKind.SomeKeyword:
                case SyntaxKind.JoinKeyword:
                case SyntaxKind.InnerKeyword:
                case SyntaxKind.CrossKeyword:
                case SyntaxKind.LeftKeyword:
                case SyntaxKind.RightKeyword:
                case SyntaxKind.OuterKeyword:
                case SyntaxKind.FullKeyword:
                case SyntaxKind.OnKeyword:
                case SyntaxKind.WithKeyword:
                case SyntaxKind.TiesKeyword:
                    return true;

                default:
                    return false;
            }
        }

        public static bool IsPunctuation(this SyntaxKind kind)
        {
            switch (kind)
            {
                case SyntaxKind.BitwiseNotToken:
                case SyntaxKind.BitwiseAndToken:
                case SyntaxKind.BitwiseOrToken:
                case SyntaxKind.BitwiseXorToken:
                case SyntaxKind.LeftParenthesesToken:
                case SyntaxKind.RightParenthesesToken:
                case SyntaxKind.PlusToken:
                case SyntaxKind.MinusToken:
                case SyntaxKind.MultiplyToken:
                case SyntaxKind.DivideToken:
                case SyntaxKind.ModulusToken:
                case SyntaxKind.PowerToken:
                case SyntaxKind.CommaToken:
                case SyntaxKind.DotToken:
                case SyntaxKind.EqualsToken:
                case SyntaxKind.UnequalsToken:
                case SyntaxKind.LessToken:
                case SyntaxKind.LessOrEqualToken:
                case SyntaxKind.GreaterToken:
                case SyntaxKind.GreaterOrEqualToken:
                case SyntaxKind.NotLessToken:
                case SyntaxKind.NotGreaterToken:
                case SyntaxKind.RightShiftToken:
                case SyntaxKind.LeftShiftToken:
                    return true;
                default:
                    return false;
            }
        }

        public static SyntaxKind GetKeywordKind(string text)
        {
            if (text == null)
                throw new ArgumentNullException("text");

            switch (text.ToUpper())
            {
                case "AND":
                    return SyntaxKind.AndKeyword;

                case "AS":
                    return SyntaxKind.AsKeyword;

                case "BETWEEN":
                    return SyntaxKind.BetweenKeyword;

                case "CASE":
                    return SyntaxKind.CaseKeyword;

                case "CAST":
                    return SyntaxKind.CastKeyword;

                case "COALESCE":
                    return SyntaxKind.CoalesceKeyword;

                case "ELSE":
                    return SyntaxKind.ElseKeyword;

                case "END":
                    return SyntaxKind.EndKeyword;

                case "FALSE":
                    return SyntaxKind.FalseKeyword;

                case "IN":
                    return SyntaxKind.InKeyword;

                case "IS":
                    return SyntaxKind.IsKeyword;

                case "LIKE":
                    return SyntaxKind.LikeKeyword;

                case "NOT":
                    return SyntaxKind.NotKeyword;

                case "NULL":
                    return SyntaxKind.NullKeyword;

                case "NULLIF":
                    return SyntaxKind.NullIfKeyword;

                case "OR":
                    return SyntaxKind.OrKeyword;

                case "ON":
                    return SyntaxKind.OnKeyword;

                case "SIMILAR":
                    return SyntaxKind.SimilarKeyword;

                case "SOUNDSLIKE":
                    return SyntaxKind.SoundslikeKeyword;

                case "THEN":
                    return SyntaxKind.ThenKeyword;

                case "TO":
                    return SyntaxKind.ToKeyword;

                case "TRUE":
                    return SyntaxKind.TrueKeyword;

                case "WHEN":
                    return SyntaxKind.WhenKeyword;

                case "ALL":
                    return SyntaxKind.AllKeyword;

                case "ANY":
                    return SyntaxKind.AnyKeyword;

                case "ASC":
                    return SyntaxKind.AscKeyword;

                case "BY":
                    return SyntaxKind.ByKeyword;

                case "CROSS":
                    return SyntaxKind.CrossKeyword;

                case "DESC":
                    return SyntaxKind.DescKeyword;

                case "DISTINCT":
                    return SyntaxKind.DistinctKeyword;

                case "EXCEPT":
                    return SyntaxKind.ExceptKeyword;

                case "EXISTS":
                    return SyntaxKind.ExistsKeyword;

                case "FROM":
                    return SyntaxKind.FromKeyword;

                case "GROUP":
                    return SyntaxKind.GroupKeyword;

                case "HAVING":
                    return SyntaxKind.HavingKeyword;

                case "INNER":
                    return SyntaxKind.InnerKeyword;

                case "INTERSECT":
                    return SyntaxKind.IntersectKeyword;

                case "JOIN":
                    return SyntaxKind.JoinKeyword;

                case "LEFT":
                    return SyntaxKind.LeftKeyword;

                case "ORDER":
                    return SyntaxKind.OrderKeyword;

                case "SELECT":
                    return SyntaxKind.SelectKeyword;

                case "SOME":
                    return SyntaxKind.SomeKeyword;

                case "TOP":
                    return SyntaxKind.TopKeyword;

                case "UNION":
                    return SyntaxKind.UnionKeyword;

                case "WHERE":
                    return SyntaxKind.WhereKeyword;

                case"RIGHT":
                    return SyntaxKind.RightKeyword;

                case "OUTER":
                    return SyntaxKind.OuterKeyword;
                
                case "FULL":
                    return SyntaxKind.FullKeyword;
                
                case "WITH":
                    return SyntaxKind.WithKeyword;
                
                case "TIES":
                    return SyntaxKind.TiesKeyword;

                default:
                    return SyntaxKind.IdentifierToken;
            }
        }

        public static SyntaxKind GetContextualKeywordKind(string text)
        {
            if (text == null)
                throw new ArgumentNullException("text");

            switch (text.ToUpper())
            {
                default:
                    return SyntaxKind.IdentifierToken;
            }
        }

        internal static SyntaxKind GetUnaryOperatorExpression(SyntaxKind token)
        {
            switch (token)
            {
                case SyntaxKind.BitwiseNotToken:
                    return SyntaxKind.ComplementExpression;

                case SyntaxKind.PlusToken:
                    return SyntaxKind.IdentityExpression;

                case SyntaxKind.MinusToken:
                    return SyntaxKind.NegationExpression;

                case SyntaxKind.NotKeyword:
                    return SyntaxKind.LogicalNotExpression;

                default:
                    return SyntaxKind.BadToken;
            }
        }

        internal static int GetUnaryOperatorPrecedence(SyntaxKind unaryExpression)
        {
            switch (unaryExpression)
            {
                case SyntaxKind.ComplementExpression:
                    return 9;

                case SyntaxKind.IdentityExpression:
                    return 9;

                case SyntaxKind.NegationExpression:
                    return 9;

                case SyntaxKind.LogicalNotExpression:
                    return 4;

                default:
                    return 0;
            }
        }

        internal static SyntaxKind GetBinaryOperatorExpression(SyntaxKind token)
        {
            switch (token)
            {
                case SyntaxKind.BitwiseAndToken:
                    return SyntaxKind.BitAndExpression;

                case SyntaxKind.BitwiseOrToken:
                    return SyntaxKind.BitOrExpression;

                case SyntaxKind.BitwiseXorToken:
                    return SyntaxKind.BitXorExpression;

                case SyntaxKind.PlusToken:
                    return SyntaxKind.AddExpression;

                case SyntaxKind.MinusToken:
                    return SyntaxKind.SubExpression;

                case SyntaxKind.MultiplyToken:
                    return SyntaxKind.MultiplyExpression;

                case SyntaxKind.DivideToken:
                    return SyntaxKind.DivideExpression;

                case SyntaxKind.ModulusToken:
                    return SyntaxKind.ModulusExpression;

                case SyntaxKind.PowerToken:
                    return SyntaxKind.PowerExpression;

                case SyntaxKind.EqualsToken:
                    return SyntaxKind.EqualExpression;

                case SyntaxKind.UnequalsToken:
                    return SyntaxKind.NotEqualExpression;

                case SyntaxKind.LessToken:
                    return SyntaxKind.LessExpression;

                case SyntaxKind.LessOrEqualToken:
                    return SyntaxKind.LessOrEqualExpression;

                case SyntaxKind.GreaterToken:
                    return SyntaxKind.GreaterExpression;

                case SyntaxKind.GreaterOrEqualToken:
                    return SyntaxKind.GreaterOrEqualExpression;

                case SyntaxKind.NotLessToken:
                    return SyntaxKind.NotLessExpression;

                case SyntaxKind.NotGreaterToken:
                    return SyntaxKind.NotGreaterExpression;

                case SyntaxKind.LeftShiftToken:
                    return SyntaxKind.LeftShiftExpression;

                case SyntaxKind.RightShiftToken:
                    return SyntaxKind.RightShiftExpression;

                case SyntaxKind.AndKeyword:
                    return SyntaxKind.LogicalAndExpression;

                case SyntaxKind.OrKeyword:
                    return SyntaxKind.LogicalOrExpression;

                case SyntaxKind.LikeKeyword:
                    return SyntaxKind.LikeExpression;

                case SyntaxKind.SoundslikeKeyword:
                    return SyntaxKind.SoundslikeExpression;

                case SyntaxKind.SimilarKeyword:
                    return SyntaxKind.SimilarToExpression;

                case SyntaxKind.InKeyword:
                    return SyntaxKind.InExpression;

                default:
                    return SyntaxKind.BadToken;
            }
        }

        internal static int GetBinaryOperatorPrecedence(SyntaxKind binaryExpression)
        {
            switch (binaryExpression)
            {
                case SyntaxKind.BitAndExpression:
                    return 5;

                case SyntaxKind.BitOrExpression:
                    return 5;

                case SyntaxKind.BitXorExpression:
                    return 5;

                case SyntaxKind.AddExpression:
                    return 7;

                case SyntaxKind.SubExpression:
                    return 7;

                case SyntaxKind.MultiplyExpression:
                    return 8;

                case SyntaxKind.DivideExpression:
                    return 8;

                case SyntaxKind.ModulusExpression:
                    return 8;

                case SyntaxKind.PowerExpression:
                    return 10;

                case SyntaxKind.EqualExpression:
                    return 6;

                case SyntaxKind.NotEqualExpression:
                    return 6;

                case SyntaxKind.LessExpression:
                    return 6;

                case SyntaxKind.LessOrEqualExpression:
                    return 6;

                case SyntaxKind.GreaterExpression:
                    return 6;

                case SyntaxKind.GreaterOrEqualExpression:
                    return 6;

                case SyntaxKind.NotLessExpression:
                    return 6;

                case SyntaxKind.NotGreaterExpression:
                    return 6;

                case SyntaxKind.LeftShiftExpression:
                    return 5;

                case SyntaxKind.RightShiftExpression:
                    return 5;

                case SyntaxKind.LogicalAndExpression:
                    return 2;

                case SyntaxKind.LogicalOrExpression:
                    return 1;

                case SyntaxKind.LikeExpression:
                    return 3;

                case SyntaxKind.SoundslikeExpression:
                    return 3;

                case SyntaxKind.SimilarToExpression:
                    return 3;

                case SyntaxKind.InExpression:
                    return 3;

                default:
                    return 0;
            }
        }

        internal static int GetTernaryOperatorPrecedence(SyntaxKind ternaryExpression)
        {
            switch (ternaryExpression)
            {
                case SyntaxKind.BetweenExpression:
                    return 4;

                default:
                    return 0;
            }
        }
    }
}