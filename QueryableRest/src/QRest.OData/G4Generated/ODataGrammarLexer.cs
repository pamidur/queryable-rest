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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public partial class ODataGrammarLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, EQPARAM=3, DOLLAR=4, AMPERSAND=5, COMMA=6, SQ=7, AND=8, 
		OR=9, NOT=10, TRUE=11, FALSE=12, GT=13, GE=14, LT=15, LE=16, EQ=17, LPAREN=18, 
		RPAREN=19, DECIMAL=20, IDENTIFIER=21, STRINGLITERAL=22, WS=23;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "EQPARAM", "DOLLAR", "AMPERSAND", "COMMA", "SQ", "AND", 
		"OR", "NOT", "TRUE", "FALSE", "GT", "GE", "LT", "LE", "EQ", "LPAREN", 
		"RPAREN", "DECIMAL", "IDENTIFIER", "STRINGLITERAL", "WS"
	};


	public ODataGrammarLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public ODataGrammarLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

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

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static ODataGrammarLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x19', '\x9C', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', 
		'\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', 
		'\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', 
		'\x5', '\v', 'V', '\n', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', 
		'\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', 
		'\x3', '\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', 
		'\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x12', '\x3', 
		'\x12', '\x3', '\x12', '\x3', '\x13', '\x3', '\x13', '\x3', '\x14', '\x3', 
		'\x14', '\x3', '\x15', '\x5', '\x15', 'w', '\n', '\x15', '\x3', '\x15', 
		'\x6', '\x15', 'z', '\n', '\x15', '\r', '\x15', '\xE', '\x15', '{', '\x3', 
		'\x15', '\x3', '\x15', '\x6', '\x15', '\x80', '\n', '\x15', '\r', '\x15', 
		'\xE', '\x15', '\x81', '\x5', '\x15', '\x84', '\n', '\x15', '\x3', '\x16', 
		'\x3', '\x16', '\a', '\x16', '\x88', '\n', '\x16', '\f', '\x16', '\xE', 
		'\x16', '\x8B', '\v', '\x16', '\x3', '\x17', '\x3', '\x17', '\a', '\x17', 
		'\x8F', '\n', '\x17', '\f', '\x17', '\xE', '\x17', '\x92', '\v', '\x17', 
		'\x3', '\x17', '\x3', '\x17', '\x3', '\x18', '\x6', '\x18', '\x97', '\n', 
		'\x18', '\r', '\x18', '\xE', '\x18', '\x98', '\x3', '\x18', '\x3', '\x18', 
		'\x2', '\x2', '\x19', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', 
		'\v', '\a', '\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', 
		'\f', '\x17', '\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', 
		'\x11', '!', '\x12', '#', '\x13', '%', '\x14', '\'', '\x15', ')', '\x16', 
		'+', '\x17', '-', '\x18', '/', '\x19', '\x3', '\x2', '\a', '\x3', '\x2', 
		')', ')', '\x3', '\x2', '\x32', ';', '\x5', '\x2', '\x43', '\\', '\x61', 
		'\x61', '\x63', '|', '\x6', '\x2', '\x32', ';', '\x43', '\\', '\x61', 
		'\x61', '\x63', '|', '\x5', '\x2', '\v', '\f', '\xE', '\xF', '\"', '\"', 
		'\x2', '\xA4', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', '\x2', 
		'\x2', '\x2', ')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', '/', '\x3', 
		'\x2', '\x2', '\x2', '\x3', '\x31', '\x3', '\x2', '\x2', '\x2', '\x5', 
		'\x38', '\x3', '\x2', '\x2', '\x2', '\a', '>', '\x3', '\x2', '\x2', '\x2', 
		'\t', '@', '\x3', '\x2', '\x2', '\x2', '\v', '\x42', '\x3', '\x2', '\x2', 
		'\x2', '\r', '\x44', '\x3', '\x2', '\x2', '\x2', '\xF', '\x46', '\x3', 
		'\x2', '\x2', '\x2', '\x11', 'H', '\x3', '\x2', '\x2', '\x2', '\x13', 
		'L', '\x3', '\x2', '\x2', '\x2', '\x15', 'U', '\x3', '\x2', '\x2', '\x2', 
		'\x17', 'W', '\x3', '\x2', '\x2', '\x2', '\x19', '\\', '\x3', '\x2', '\x2', 
		'\x2', '\x1B', '\x62', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x65', '\x3', 
		'\x2', '\x2', '\x2', '\x1F', 'h', '\x3', '\x2', '\x2', '\x2', '!', 'k', 
		'\x3', '\x2', '\x2', '\x2', '#', 'n', '\x3', '\x2', '\x2', '\x2', '%', 
		'q', '\x3', '\x2', '\x2', '\x2', '\'', 's', '\x3', '\x2', '\x2', '\x2', 
		')', 'v', '\x3', '\x2', '\x2', '\x2', '+', '\x85', '\x3', '\x2', '\x2', 
		'\x2', '-', '\x8C', '\x3', '\x2', '\x2', '\x2', '/', '\x96', '\x3', '\x2', 
		'\x2', '\x2', '\x31', '\x32', '\a', 'h', '\x2', '\x2', '\x32', '\x33', 
		'\a', 'k', '\x2', '\x2', '\x33', '\x34', '\a', 'n', '\x2', '\x2', '\x34', 
		'\x35', '\a', 'v', '\x2', '\x2', '\x35', '\x36', '\a', 'g', '\x2', '\x2', 
		'\x36', '\x37', '\a', 't', '\x2', '\x2', '\x37', '\x4', '\x3', '\x2', 
		'\x2', '\x2', '\x38', '\x39', '\a', '\x65', '\x2', '\x2', '\x39', ':', 
		'\a', 'q', '\x2', '\x2', ':', ';', '\a', 'w', '\x2', '\x2', ';', '<', 
		'\a', 'p', '\x2', '\x2', '<', '=', '\a', 'v', '\x2', '\x2', '=', '\x6', 
		'\x3', '\x2', '\x2', '\x2', '>', '?', '\a', '?', '\x2', '\x2', '?', '\b', 
		'\x3', '\x2', '\x2', '\x2', '@', '\x41', '\a', '&', '\x2', '\x2', '\x41', 
		'\n', '\x3', '\x2', '\x2', '\x2', '\x42', '\x43', '\a', '(', '\x2', '\x2', 
		'\x43', '\f', '\x3', '\x2', '\x2', '\x2', '\x44', '\x45', '\a', '.', '\x2', 
		'\x2', '\x45', '\xE', '\x3', '\x2', '\x2', '\x2', '\x46', 'G', '\t', '\x2', 
		'\x2', '\x2', 'G', '\x10', '\x3', '\x2', '\x2', '\x2', 'H', 'I', '\a', 
		'\x43', '\x2', '\x2', 'I', 'J', '\a', 'P', '\x2', '\x2', 'J', 'K', '\a', 
		'\x46', '\x2', '\x2', 'K', '\x12', '\x3', '\x2', '\x2', '\x2', 'L', 'M', 
		'\a', 'Q', '\x2', '\x2', 'M', 'N', '\a', 'T', '\x2', '\x2', 'N', '\x14', 
		'\x3', '\x2', '\x2', '\x2', 'O', 'P', '\a', 'P', '\x2', '\x2', 'P', 'Q', 
		'\a', 'Q', '\x2', '\x2', 'Q', 'V', '\a', 'V', '\x2', '\x2', 'R', 'V', 
		'\a', '#', '\x2', '\x2', 'S', 'T', '\a', '>', '\x2', '\x2', 'T', 'V', 
		'\a', '@', '\x2', '\x2', 'U', 'O', '\x3', '\x2', '\x2', '\x2', 'U', 'R', 
		'\x3', '\x2', '\x2', '\x2', 'U', 'S', '\x3', '\x2', '\x2', '\x2', 'V', 
		'\x16', '\x3', '\x2', '\x2', '\x2', 'W', 'X', '\a', 'V', '\x2', '\x2', 
		'X', 'Y', '\a', 'T', '\x2', '\x2', 'Y', 'Z', '\a', 'W', '\x2', '\x2', 
		'Z', '[', '\a', 'G', '\x2', '\x2', '[', '\x18', '\x3', '\x2', '\x2', '\x2', 
		'\\', ']', '\a', 'H', '\x2', '\x2', ']', '^', '\a', '\x43', '\x2', '\x2', 
		'^', '_', '\a', 'N', '\x2', '\x2', '_', '`', '\a', 'U', '\x2', '\x2', 
		'`', '\x61', '\a', 'G', '\x2', '\x2', '\x61', '\x1A', '\x3', '\x2', '\x2', 
		'\x2', '\x62', '\x63', '\a', 'i', '\x2', '\x2', '\x63', '\x64', '\a', 
		'v', '\x2', '\x2', '\x64', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x65', 
		'\x66', '\a', 'i', '\x2', '\x2', '\x66', 'g', '\a', 'g', '\x2', '\x2', 
		'g', '\x1E', '\x3', '\x2', '\x2', '\x2', 'h', 'i', '\a', 'n', '\x2', '\x2', 
		'i', 'j', '\a', 'v', '\x2', '\x2', 'j', ' ', '\x3', '\x2', '\x2', '\x2', 
		'k', 'l', '\a', 'n', '\x2', '\x2', 'l', 'm', '\a', 'g', '\x2', '\x2', 
		'm', '\"', '\x3', '\x2', '\x2', '\x2', 'n', 'o', '\a', 'g', '\x2', '\x2', 
		'o', 'p', '\a', 's', '\x2', '\x2', 'p', '$', '\x3', '\x2', '\x2', '\x2', 
		'q', 'r', '\a', '*', '\x2', '\x2', 'r', '&', '\x3', '\x2', '\x2', '\x2', 
		's', 't', '\a', '+', '\x2', '\x2', 't', '(', '\x3', '\x2', '\x2', '\x2', 
		'u', 'w', '\a', '/', '\x2', '\x2', 'v', 'u', '\x3', '\x2', '\x2', '\x2', 
		'v', 'w', '\x3', '\x2', '\x2', '\x2', 'w', 'y', '\x3', '\x2', '\x2', '\x2', 
		'x', 'z', '\t', '\x3', '\x2', '\x2', 'y', 'x', '\x3', '\x2', '\x2', '\x2', 
		'z', '{', '\x3', '\x2', '\x2', '\x2', '{', 'y', '\x3', '\x2', '\x2', '\x2', 
		'{', '|', '\x3', '\x2', '\x2', '\x2', '|', '\x83', '\x3', '\x2', '\x2', 
		'\x2', '}', '\x7F', '\a', '\x30', '\x2', '\x2', '~', '\x80', '\t', '\x3', 
		'\x2', '\x2', '\x7F', '~', '\x3', '\x2', '\x2', '\x2', '\x80', '\x81', 
		'\x3', '\x2', '\x2', '\x2', '\x81', '\x7F', '\x3', '\x2', '\x2', '\x2', 
		'\x81', '\x82', '\x3', '\x2', '\x2', '\x2', '\x82', '\x84', '\x3', '\x2', 
		'\x2', '\x2', '\x83', '}', '\x3', '\x2', '\x2', '\x2', '\x83', '\x84', 
		'\x3', '\x2', '\x2', '\x2', '\x84', '*', '\x3', '\x2', '\x2', '\x2', '\x85', 
		'\x89', '\t', '\x4', '\x2', '\x2', '\x86', '\x88', '\t', '\x5', '\x2', 
		'\x2', '\x87', '\x86', '\x3', '\x2', '\x2', '\x2', '\x88', '\x8B', '\x3', 
		'\x2', '\x2', '\x2', '\x89', '\x87', '\x3', '\x2', '\x2', '\x2', '\x89', 
		'\x8A', '\x3', '\x2', '\x2', '\x2', '\x8A', ',', '\x3', '\x2', '\x2', 
		'\x2', '\x8B', '\x89', '\x3', '\x2', '\x2', '\x2', '\x8C', '\x90', '\x5', 
		'\xF', '\b', '\x2', '\x8D', '\x8F', '\t', '\x5', '\x2', '\x2', '\x8E', 
		'\x8D', '\x3', '\x2', '\x2', '\x2', '\x8F', '\x92', '\x3', '\x2', '\x2', 
		'\x2', '\x90', '\x8E', '\x3', '\x2', '\x2', '\x2', '\x90', '\x91', '\x3', 
		'\x2', '\x2', '\x2', '\x91', '\x93', '\x3', '\x2', '\x2', '\x2', '\x92', 
		'\x90', '\x3', '\x2', '\x2', '\x2', '\x93', '\x94', '\x5', '\xF', '\b', 
		'\x2', '\x94', '.', '\x3', '\x2', '\x2', '\x2', '\x95', '\x97', '\t', 
		'\x6', '\x2', '\x2', '\x96', '\x95', '\x3', '\x2', '\x2', '\x2', '\x97', 
		'\x98', '\x3', '\x2', '\x2', '\x2', '\x98', '\x96', '\x3', '\x2', '\x2', 
		'\x2', '\x98', '\x99', '\x3', '\x2', '\x2', '\x2', '\x99', '\x9A', '\x3', 
		'\x2', '\x2', '\x2', '\x9A', '\x9B', '\b', '\x18', '\x2', '\x2', '\x9B', 
		'\x30', '\x3', '\x2', '\x2', '\x2', '\v', '\x2', 'U', 'v', '{', '\x81', 
		'\x83', '\x89', '\x90', '\x98', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
