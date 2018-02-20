//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ODataGrammar.g4 by ANTLR 4.7.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public partial class ODataGrammarParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, EQPARAM=3, DOLLAR=4, AMPERSAND=5, COMMA=6, SQ=7, AND=8, 
		OR=9, NOT=10, TRUE=11, FALSE=12, GT=13, GE=14, LT=15, LE=16, EQ=17, LPAREN=18, 
		RPAREN=19, DECIMAL=20, IDENTIFIER=21, STRINGLITERAL=22, WS=23;
	public const int
		RULE_parse = 0, RULE_queryOptions = 1, RULE_queryOption = 2, RULE_odataQueryOption = 3, 
		RULE_filter = 4, RULE_count = 5, RULE_expression = 6, RULE_comparator = 7, 
		RULE_binary = 8, RULE_bool = 9, RULE_functionParams = 10;
	public static readonly string[] ruleNames = {
		"parse", "queryOptions", "queryOption", "odataQueryOption", "filter", 
		"count", "expression", "comparator", "binary", "bool", "functionParams"
	};

	private static readonly string[] _LiteralNames = {
		null, "'filter'", "'count'", "'='", "'$'", "'&'", "','", null, "'AND'", 
		"'OR'", null, "'TRUE'", "'FALSE'", "'gt'", "'ge'", "'lt'", "'le'", "'eq'", 
		"'('", "')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, "EQPARAM", "DOLLAR", "AMPERSAND", "COMMA", "SQ", "AND", 
		"OR", "NOT", "TRUE", "FALSE", "GT", "GE", "LT", "LE", "EQ", "LPAREN", 
		"RPAREN", "DECIMAL", "IDENTIFIER", "STRINGLITERAL", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "ODataGrammar.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static ODataGrammarParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public ODataGrammarParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public ODataGrammarParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}
	public partial class ParseContext : ParserRuleContext {
		public QueryOptionsContext queryOptions() {
			return GetRuleContext<QueryOptionsContext>(0);
		}
		public ITerminalNode Eof() { return GetToken(ODataGrammarParser.Eof, 0); }
		public ParseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_parse; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IODataGrammarVisitor<TResult> typedVisitor = visitor as IODataGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParse(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ParseContext parse() {
		ParseContext _localctx = new ParseContext(Context, State);
		EnterRule(_localctx, 0, RULE_parse);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 22; queryOptions();
			State = 23; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class QueryOptionsContext : ParserRuleContext {
		public QueryOptionContext[] queryOption() {
			return GetRuleContexts<QueryOptionContext>();
		}
		public QueryOptionContext queryOption(int i) {
			return GetRuleContext<QueryOptionContext>(i);
		}
		public ITerminalNode[] AMPERSAND() { return GetTokens(ODataGrammarParser.AMPERSAND); }
		public ITerminalNode AMPERSAND(int i) {
			return GetToken(ODataGrammarParser.AMPERSAND, i);
		}
		public QueryOptionsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_queryOptions; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IODataGrammarVisitor<TResult> typedVisitor = visitor as IODataGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitQueryOptions(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public QueryOptionsContext queryOptions() {
		QueryOptionsContext _localctx = new QueryOptionsContext(Context, State);
		EnterRule(_localctx, 2, RULE_queryOptions);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 25; queryOption();
			State = 30;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==AMPERSAND) {
				{
				{
				State = 26; Match(AMPERSAND);
				State = 27; queryOption();
				}
				}
				State = 32;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class QueryOptionContext : ParserRuleContext {
		public OdataQueryOptionContext odataQueryOption() {
			return GetRuleContext<OdataQueryOptionContext>(0);
		}
		public QueryOptionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_queryOption; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IODataGrammarVisitor<TResult> typedVisitor = visitor as IODataGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitQueryOption(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public QueryOptionContext queryOption() {
		QueryOptionContext _localctx = new QueryOptionContext(Context, State);
		EnterRule(_localctx, 4, RULE_queryOption);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 33; odataQueryOption();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class OdataQueryOptionContext : ParserRuleContext {
		public FilterContext filter() {
			return GetRuleContext<FilterContext>(0);
		}
		public CountContext count() {
			return GetRuleContext<CountContext>(0);
		}
		public OdataQueryOptionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_odataQueryOption; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IODataGrammarVisitor<TResult> typedVisitor = visitor as IODataGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitOdataQueryOption(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public OdataQueryOptionContext odataQueryOption() {
		OdataQueryOptionContext _localctx = new OdataQueryOptionContext(Context, State);
		EnterRule(_localctx, 6, RULE_odataQueryOption);
		try {
			State = 37;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,1,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 35; filter();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 36; count();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FilterContext : ParserRuleContext {
		public ExpressionContext filterexpr;
		public ITerminalNode DOLLAR() { return GetToken(ODataGrammarParser.DOLLAR, 0); }
		public ITerminalNode EQPARAM() { return GetToken(ODataGrammarParser.EQPARAM, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public FilterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_filter; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IODataGrammarVisitor<TResult> typedVisitor = visitor as IODataGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFilter(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FilterContext filter() {
		FilterContext _localctx = new FilterContext(Context, State);
		EnterRule(_localctx, 8, RULE_filter);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 39; Match(DOLLAR);
			State = 40; Match(T__0);
			State = 41; Match(EQPARAM);
			State = 42; _localctx.filterexpr = expression(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class CountContext : ParserRuleContext {
		public ITerminalNode DOLLAR() { return GetToken(ODataGrammarParser.DOLLAR, 0); }
		public ITerminalNode EQPARAM() { return GetToken(ODataGrammarParser.EQPARAM, 0); }
		public BoolContext @bool() {
			return GetRuleContext<BoolContext>(0);
		}
		public CountContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_count; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IODataGrammarVisitor<TResult> typedVisitor = visitor as IODataGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCount(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public CountContext count() {
		CountContext _localctx = new CountContext(Context, State);
		EnterRule(_localctx, 10, RULE_count);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 44; Match(DOLLAR);
			State = 45; Match(T__1);
			State = 46; Match(EQPARAM);
			State = 47; @bool();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpressionContext : ParserRuleContext {
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
	 
		public ExpressionContext() { }
		public virtual void CopyFrom(ExpressionContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class BinaryExpressionContext : ExpressionContext {
		public ExpressionContext left;
		public BinaryContext op;
		public ExpressionContext right;
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public BinaryContext binary() {
			return GetRuleContext<BinaryContext>(0);
		}
		public BinaryExpressionContext(ExpressionContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IODataGrammarVisitor<TResult> typedVisitor = visitor as IODataGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBinaryExpression(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class DecimalExpressionContext : ExpressionContext {
		public ITerminalNode DECIMAL() { return GetToken(ODataGrammarParser.DECIMAL, 0); }
		public DecimalExpressionContext(ExpressionContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IODataGrammarVisitor<TResult> typedVisitor = visitor as IODataGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDecimalExpression(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class StringExpressionContext : ExpressionContext {
		public ITerminalNode STRINGLITERAL() { return GetToken(ODataGrammarParser.STRINGLITERAL, 0); }
		public StringExpressionContext(ExpressionContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IODataGrammarVisitor<TResult> typedVisitor = visitor as IODataGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStringExpression(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class BoolExpressionContext : ExpressionContext {
		public BoolContext @bool() {
			return GetRuleContext<BoolContext>(0);
		}
		public BoolExpressionContext(ExpressionContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IODataGrammarVisitor<TResult> typedVisitor = visitor as IODataGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBoolExpression(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class IdentifierExpressionContext : ExpressionContext {
		public ITerminalNode IDENTIFIER() { return GetToken(ODataGrammarParser.IDENTIFIER, 0); }
		public IdentifierExpressionContext(ExpressionContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IODataGrammarVisitor<TResult> typedVisitor = visitor as IODataGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIdentifierExpression(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class NotExpressionContext : ExpressionContext {
		public ITerminalNode NOT() { return GetToken(ODataGrammarParser.NOT, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public NotExpressionContext(ExpressionContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IODataGrammarVisitor<TResult> typedVisitor = visitor as IODataGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNotExpression(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ParenExpressionContext : ExpressionContext {
		public ITerminalNode LPAREN() { return GetToken(ODataGrammarParser.LPAREN, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(ODataGrammarParser.RPAREN, 0); }
		public ParenExpressionContext(ExpressionContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IODataGrammarVisitor<TResult> typedVisitor = visitor as IODataGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParenExpression(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ComparatorExpressionContext : ExpressionContext {
		public ExpressionContext left;
		public ComparatorContext op;
		public ExpressionContext right;
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ComparatorContext comparator() {
			return GetRuleContext<ComparatorContext>(0);
		}
		public ComparatorExpressionContext(ExpressionContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IODataGrammarVisitor<TResult> typedVisitor = visitor as IODataGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitComparatorExpression(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class FuncCallExpressionContext : ExpressionContext {
		public IToken func;
		public ITerminalNode LPAREN() { return GetToken(ODataGrammarParser.LPAREN, 0); }
		public FunctionParamsContext functionParams() {
			return GetRuleContext<FunctionParamsContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(ODataGrammarParser.RPAREN, 0); }
		public ITerminalNode IDENTIFIER() { return GetToken(ODataGrammarParser.IDENTIFIER, 0); }
		public FuncCallExpressionContext(ExpressionContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IODataGrammarVisitor<TResult> typedVisitor = visitor as IODataGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFuncCallExpression(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionContext expression() {
		return expression(0);
	}

	private ExpressionContext expression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ExpressionContext _localctx = new ExpressionContext(Context, _parentState);
		ExpressionContext _prevctx = _localctx;
		int _startState = 12;
		EnterRecursionRule(_localctx, 12, RULE_expression, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 65;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,2,Context) ) {
			case 1:
				{
				_localctx = new ParenExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;

				State = 50; Match(LPAREN);
				State = 51; expression(0);
				State = 52; Match(RPAREN);
				}
				break;
			case 2:
				{
				_localctx = new NotExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 54; Match(NOT);
				State = 55; expression(8);
				}
				break;
			case 3:
				{
				_localctx = new BoolExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 56; @bool();
				}
				break;
			case 4:
				{
				_localctx = new IdentifierExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 57; Match(IDENTIFIER);
				}
				break;
			case 5:
				{
				_localctx = new DecimalExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 58; Match(DECIMAL);
				}
				break;
			case 6:
				{
				_localctx = new StringExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 59; Match(STRINGLITERAL);
				}
				break;
			case 7:
				{
				_localctx = new FuncCallExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 60; ((FuncCallExpressionContext)_localctx).func = Match(IDENTIFIER);
				State = 61; Match(LPAREN);
				State = 62; functionParams();
				State = 63; Match(RPAREN);
				}
				break;
			}
			Context.Stop = TokenStream.LT(-1);
			State = 77;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 75;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,3,Context) ) {
					case 1:
						{
						_localctx = new ComparatorExpressionContext(new ExpressionContext(_parentctx, _parentState));
						((ComparatorExpressionContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 67;
						if (!(Precpred(Context, 7))) throw new FailedPredicateException(this, "Precpred(Context, 7)");
						State = 68; ((ComparatorExpressionContext)_localctx).op = comparator();
						State = 69; ((ComparatorExpressionContext)_localctx).right = expression(8);
						}
						break;
					case 2:
						{
						_localctx = new BinaryExpressionContext(new ExpressionContext(_parentctx, _parentState));
						((BinaryExpressionContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 71;
						if (!(Precpred(Context, 6))) throw new FailedPredicateException(this, "Precpred(Context, 6)");
						State = 72; ((BinaryExpressionContext)_localctx).op = binary();
						State = 73; ((BinaryExpressionContext)_localctx).right = expression(7);
						}
						break;
					}
					} 
				}
				State = 79;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class ComparatorContext : ParserRuleContext {
		public ITerminalNode GT() { return GetToken(ODataGrammarParser.GT, 0); }
		public ITerminalNode GE() { return GetToken(ODataGrammarParser.GE, 0); }
		public ITerminalNode LT() { return GetToken(ODataGrammarParser.LT, 0); }
		public ITerminalNode LE() { return GetToken(ODataGrammarParser.LE, 0); }
		public ITerminalNode EQ() { return GetToken(ODataGrammarParser.EQ, 0); }
		public ComparatorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_comparator; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IODataGrammarVisitor<TResult> typedVisitor = visitor as IODataGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitComparator(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ComparatorContext comparator() {
		ComparatorContext _localctx = new ComparatorContext(Context, State);
		EnterRule(_localctx, 14, RULE_comparator);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 80;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << GT) | (1L << GE) | (1L << LT) | (1L << LE) | (1L << EQ))) != 0)) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BinaryContext : ParserRuleContext {
		public ITerminalNode AND() { return GetToken(ODataGrammarParser.AND, 0); }
		public ITerminalNode OR() { return GetToken(ODataGrammarParser.OR, 0); }
		public BinaryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_binary; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IODataGrammarVisitor<TResult> typedVisitor = visitor as IODataGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBinary(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public BinaryContext binary() {
		BinaryContext _localctx = new BinaryContext(Context, State);
		EnterRule(_localctx, 16, RULE_binary);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 82;
			_la = TokenStream.LA(1);
			if ( !(_la==AND || _la==OR) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BoolContext : ParserRuleContext {
		public ITerminalNode TRUE() { return GetToken(ODataGrammarParser.TRUE, 0); }
		public ITerminalNode FALSE() { return GetToken(ODataGrammarParser.FALSE, 0); }
		public BoolContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_bool; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IODataGrammarVisitor<TResult> typedVisitor = visitor as IODataGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBool(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public BoolContext @bool() {
		BoolContext _localctx = new BoolContext(Context, State);
		EnterRule(_localctx, 18, RULE_bool);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 84;
			_la = TokenStream.LA(1);
			if ( !(_la==TRUE || _la==FALSE) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FunctionParamsContext : ParserRuleContext {
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode[] COMMA() { return GetTokens(ODataGrammarParser.COMMA); }
		public ITerminalNode COMMA(int i) {
			return GetToken(ODataGrammarParser.COMMA, i);
		}
		public FunctionParamsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_functionParams; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IODataGrammarVisitor<TResult> typedVisitor = visitor as IODataGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFunctionParams(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FunctionParamsContext functionParams() {
		FunctionParamsContext _localctx = new FunctionParamsContext(Context, State);
		EnterRule(_localctx, 20, RULE_functionParams);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 86; expression(0);
			State = 91;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 87; Match(COMMA);
				State = 88; expression(0);
				}
				}
				State = 93;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 6: return expression_sempred((ExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expression_sempred(ExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 7);
		case 1: return Precpred(Context, 6);
		}
		return true;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x19', '\x61', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', 
		'\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', '\t', '\v', 
		'\x4', '\f', '\t', '\f', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\a', '\x3', '\x1F', '\n', '\x3', '\f', 
		'\x3', '\xE', '\x3', '\"', '\v', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x5', '\x3', '\x5', '\x5', '\x5', '(', '\n', '\x5', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x5', '\b', '\x44', '\n', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\a', '\b', 'N', '\n', '\b', '\f', '\b', '\xE', 
		'\b', 'Q', '\v', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', 
		'\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\a', 
		'\f', '\\', '\n', '\f', '\f', '\f', '\xE', '\f', '_', '\v', '\f', '\x3', 
		'\f', '\x2', '\x3', '\xE', '\r', '\x2', '\x4', '\x6', '\b', '\n', '\f', 
		'\xE', '\x10', '\x12', '\x14', '\x16', '\x2', '\x5', '\x3', '\x2', '\xF', 
		'\x13', '\x3', '\x2', '\n', '\v', '\x3', '\x2', '\r', '\xE', '\x2', '`', 
		'\x2', '\x18', '\x3', '\x2', '\x2', '\x2', '\x4', '\x1B', '\x3', '\x2', 
		'\x2', '\x2', '\x6', '#', '\x3', '\x2', '\x2', '\x2', '\b', '\'', '\x3', 
		'\x2', '\x2', '\x2', '\n', ')', '\x3', '\x2', '\x2', '\x2', '\f', '.', 
		'\x3', '\x2', '\x2', '\x2', '\xE', '\x43', '\x3', '\x2', '\x2', '\x2', 
		'\x10', 'R', '\x3', '\x2', '\x2', '\x2', '\x12', 'T', '\x3', '\x2', '\x2', 
		'\x2', '\x14', 'V', '\x3', '\x2', '\x2', '\x2', '\x16', 'X', '\x3', '\x2', 
		'\x2', '\x2', '\x18', '\x19', '\x5', '\x4', '\x3', '\x2', '\x19', '\x1A', 
		'\a', '\x2', '\x2', '\x3', '\x1A', '\x3', '\x3', '\x2', '\x2', '\x2', 
		'\x1B', ' ', '\x5', '\x6', '\x4', '\x2', '\x1C', '\x1D', '\a', '\a', '\x2', 
		'\x2', '\x1D', '\x1F', '\x5', '\x6', '\x4', '\x2', '\x1E', '\x1C', '\x3', 
		'\x2', '\x2', '\x2', '\x1F', '\"', '\x3', '\x2', '\x2', '\x2', ' ', '\x1E', 
		'\x3', '\x2', '\x2', '\x2', ' ', '!', '\x3', '\x2', '\x2', '\x2', '!', 
		'\x5', '\x3', '\x2', '\x2', '\x2', '\"', ' ', '\x3', '\x2', '\x2', '\x2', 
		'#', '$', '\x5', '\b', '\x5', '\x2', '$', '\a', '\x3', '\x2', '\x2', '\x2', 
		'%', '(', '\x5', '\n', '\x6', '\x2', '&', '(', '\x5', '\f', '\a', '\x2', 
		'\'', '%', '\x3', '\x2', '\x2', '\x2', '\'', '&', '\x3', '\x2', '\x2', 
		'\x2', '(', '\t', '\x3', '\x2', '\x2', '\x2', ')', '*', '\a', '\x6', '\x2', 
		'\x2', '*', '+', '\a', '\x3', '\x2', '\x2', '+', ',', '\a', '\x5', '\x2', 
		'\x2', ',', '-', '\x5', '\xE', '\b', '\x2', '-', '\v', '\x3', '\x2', '\x2', 
		'\x2', '.', '/', '\a', '\x6', '\x2', '\x2', '/', '\x30', '\a', '\x4', 
		'\x2', '\x2', '\x30', '\x31', '\a', '\x5', '\x2', '\x2', '\x31', '\x32', 
		'\x5', '\x14', '\v', '\x2', '\x32', '\r', '\x3', '\x2', '\x2', '\x2', 
		'\x33', '\x34', '\b', '\b', '\x1', '\x2', '\x34', '\x35', '\a', '\x14', 
		'\x2', '\x2', '\x35', '\x36', '\x5', '\xE', '\b', '\x2', '\x36', '\x37', 
		'\a', '\x15', '\x2', '\x2', '\x37', '\x44', '\x3', '\x2', '\x2', '\x2', 
		'\x38', '\x39', '\a', '\f', '\x2', '\x2', '\x39', '\x44', '\x5', '\xE', 
		'\b', '\n', ':', '\x44', '\x5', '\x14', '\v', '\x2', ';', '\x44', '\a', 
		'\x17', '\x2', '\x2', '<', '\x44', '\a', '\x16', '\x2', '\x2', '=', '\x44', 
		'\a', '\x18', '\x2', '\x2', '>', '?', '\a', '\x17', '\x2', '\x2', '?', 
		'@', '\a', '\x14', '\x2', '\x2', '@', '\x41', '\x5', '\x16', '\f', '\x2', 
		'\x41', '\x42', '\a', '\x15', '\x2', '\x2', '\x42', '\x44', '\x3', '\x2', 
		'\x2', '\x2', '\x43', '\x33', '\x3', '\x2', '\x2', '\x2', '\x43', '\x38', 
		'\x3', '\x2', '\x2', '\x2', '\x43', ':', '\x3', '\x2', '\x2', '\x2', '\x43', 
		';', '\x3', '\x2', '\x2', '\x2', '\x43', '<', '\x3', '\x2', '\x2', '\x2', 
		'\x43', '=', '\x3', '\x2', '\x2', '\x2', '\x43', '>', '\x3', '\x2', '\x2', 
		'\x2', '\x44', 'O', '\x3', '\x2', '\x2', '\x2', '\x45', '\x46', '\f', 
		'\t', '\x2', '\x2', '\x46', 'G', '\x5', '\x10', '\t', '\x2', 'G', 'H', 
		'\x5', '\xE', '\b', '\n', 'H', 'N', '\x3', '\x2', '\x2', '\x2', 'I', 'J', 
		'\f', '\b', '\x2', '\x2', 'J', 'K', '\x5', '\x12', '\n', '\x2', 'K', 'L', 
		'\x5', '\xE', '\b', '\t', 'L', 'N', '\x3', '\x2', '\x2', '\x2', 'M', '\x45', 
		'\x3', '\x2', '\x2', '\x2', 'M', 'I', '\x3', '\x2', '\x2', '\x2', 'N', 
		'Q', '\x3', '\x2', '\x2', '\x2', 'O', 'M', '\x3', '\x2', '\x2', '\x2', 
		'O', 'P', '\x3', '\x2', '\x2', '\x2', 'P', '\xF', '\x3', '\x2', '\x2', 
		'\x2', 'Q', 'O', '\x3', '\x2', '\x2', '\x2', 'R', 'S', '\t', '\x2', '\x2', 
		'\x2', 'S', '\x11', '\x3', '\x2', '\x2', '\x2', 'T', 'U', '\t', '\x3', 
		'\x2', '\x2', 'U', '\x13', '\x3', '\x2', '\x2', '\x2', 'V', 'W', '\t', 
		'\x4', '\x2', '\x2', 'W', '\x15', '\x3', '\x2', '\x2', '\x2', 'X', ']', 
		'\x5', '\xE', '\b', '\x2', 'Y', 'Z', '\a', '\b', '\x2', '\x2', 'Z', '\\', 
		'\x5', '\xE', '\b', '\x2', '[', 'Y', '\x3', '\x2', '\x2', '\x2', '\\', 
		'_', '\x3', '\x2', '\x2', '\x2', ']', '[', '\x3', '\x2', '\x2', '\x2', 
		']', '^', '\x3', '\x2', '\x2', '\x2', '^', '\x17', '\x3', '\x2', '\x2', 
		'\x2', '_', ']', '\x3', '\x2', '\x2', '\x2', '\b', ' ', '\'', '\x43', 
		'M', 'O', ']',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
