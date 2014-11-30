﻿namespace Main
{
    public static class StopWords
    {
        public static string[] StopWordsList(bool isNeg)
        {
            return isNeg ? StopWordsListNeg : StopWordsListPos;
        } 

        public static string[] StopWordsListPos =
        {
            "comedi",
            "play",
            "exact",
            "tri",
            "desper",
            "cri",
            "dub",
            "fan",
            "scrappi",
            "recent",
            "start",
            "open",
            "number",
            "thing",
            "job",
            "rain",
            "soak",
            "day",
            "add",
            "psycholog",
            "marti",
            "ll",
            "reluct",
            "abl",
            "toy",
            "emot",
            "exact",
            "sold",
            "move",
            "exit",
            "full",
            "tri",
            "cri",
            "great",
            "turn",
            "follow",
            "promis",
            "frailti",
            "famili",
            "sport",
            "number",
            "dub",
            "scrappi",
            "dime",
            "dozen",
            "recent",
            "miracl",
            "cinderella",
            "man",
            "film",
            "open",
            "credit",
            "imagin",
            "version",
            "hour",
            "action",
            "thing",
            "knack",
            "went"	,
            "ll",
            "saw"	,
            "movie"	,
             "night"	,
            "coax"	,
            "friend"	,
            "admit"	,
            "reluct"	,
            "see"	,
            "knew"	,
            "ashton"	,
            "comedi"	,
            "wrong"	,
            "play"	,
            "charact"	,
            "ben"	,
            "randal"	,
            "profession"	,
            "sign"	,
            "good"	,
            "emot"	,
            "exact"	,
            "entire"	,
            "theater"	,
            "half"	,
            "move"	,
            "tear"	,
            "exit"	,
            "women"	,
            "grown"	,
            "men"	,
            "tri"	,
            "desper"	,
            "let"	,
            "cri"	,
            "go"	,
            "judg"	,
            "actor"	,
            "turn"	,
            "director"	,
            "bill"	,
            "paxton"	,
            "promis"	,
            "debut"	,
            "gothic"	,
            "horror"	,
            "frailti"	,
            "famili"	,
            "sport"	,
            "drama"	,
            "young"	,
            "golf"	,
            "scrappi"	,
            "marti"	,
			"a", 																													  
			"about", 
			"above", 
			"across", 
			"afore", 
			"aforesaid", 
			"after", 
			"again", 
			"against", 
			"agin", 
			"ago", 
			"aint", 
			"albeit", 
			"all", 
			"almost", 
			"alone", 
			"along", 
			"alongside", 
			"already", 
			"also", 
			"although", 
			"always", 
			"am", 
			"american", 
			"amid", 
			"amidst", 
			"among", 
			"amongst", 
			"an", 
			"and", 
			"anent", 
			"another", 
			"any", 
			"anybody", 
			"anyone", 
			"anything", 
			"are", 
			"aren't", 
			"around", 
			"as", 
			"aslant", 
			"astride", 
			"at", 
			"athwart", 
			"away", 
			"b", 
			"back", 
			"bar", 
			"barring", 
			"be", 
			"because", 
			"been", 
			"before", 
			"behind", 
			"being", 
			"below", 
			"beneath", 
			"beside", 
			"besides", 
			"best", 
			"better", 
			"between", 
			"betwixt", 
			"beyond", 
			"both", 
			"but", 
			"by", 
			"c", 
			"can", 
			"cannot", 
			"can't", 
			"certain", 
			"circa", 
			"close", 
			"concerning", 
			"considering", 
			"cos", 
			"could", 
			"couldn't", 
			"couldst", 
			"d", 
			"dare", 
			"dared", 
			"daren't", 
			"dares", 
			"daring", 
			"despite", 
			"did", 
			"didn't", 
			"different", 
			"directly", 
			"do", 
			"does", 
			"doesn't", 
			"doing", 
			"done", 
			"don't", 
			"dost", 
			"doth", 
			"down", 
			"during", 
			"durst", 
			"e", 
			"each", 
			"early", 
			"either", 
			"em", 
			"english", 
			"enough", 
			"ere", 
			"even", 
			"ever", 
			"every", 
			"everybody", 
			"everyone", 
			"everything", 
			"except", 
			"excepting", 
			"f", 
			"failing", 
			"far", 
			"few", 
			"first", 
			"five", 
			"following", 
			"for", 
			"four", 
			"from", 
			"g", 
			"gonna", 
			"gotta", 
			"h", 
			"had", 
			"hadn't", 
			"hard", 
			"has", 
			"hasn't", 
			"hast", 
			"hath", 
			"have", 
			"haven't", 
			"having", 
			"he", 
			"he'd", 
			"he'll", 
			"her", 
			"here", 
			"here's", 
			"hers", 
			"herself", 
			"he's", 
			"high", 
			"him", 
			"himself", 
			"his", 
			"home", 
			"how", 
			"howbeit", 
			"however", 
			"how's", 
			"i", 
			"id", 
			"if", 
			"ill", 
			"i'm", 
			"immediately", 
			"important", 
			"in", 
			"inside", 
			"instantly", 
			"into", 
			"is", 
			"isn't", 
			"it", 
			"it'll", 
			"it's", 
			"its", 
			"itself", 
			"i've", 
			"j", 
			"just", 
			"k", 
			"l", 
			"large", 
			"last", 
			"later", 
			"least", 
			"left", 
			"less", 
			"lest", 
			"let's", 
			"like", 
			"likewise", 
			"little", 
			"living", 
			"long", 
			"m", 
			"many", 
			"may", 
			"mayn't", 
			"me", 
			"mid", 
			"midst", 
			"might", 
			"mightn't", 
			"mine", 
			"minus", 
			"more", 
			"most", 
			"much", 
			"must", 
			"mustn't", 
			"my", 
			"myself", 
			"n", 
			"near", 
			"'neath", 
			"need", 
			"needed", 
			"needing", 
			"needn't", 
			"needs", 
			"neither", 
			"never", 
			"nevertheless", 
			"new", 
			"next", 
			"nigh", 
			"nigher", 
			"nighest", 
			"nisi", 
			"no", 
			"no-one", 
			"nobody", 
			"none", 
			"nor", 
			"not", 
			"nothing", 
			"notwithstanding", 
			"now", 
			"o", 
			"o'er", 
			"of", 
			"off", 
			"often", 
			"on", 
			"once", 
			"one", 
			"oneself", 
			"only", 
			"onto", 
			"open", 
			"or", 
			"other", 
			"otherwise", 
			"ought", 
			"oughtn't", 
			"our", 
			"ours", 
			"ourselves", 
			"out", 
			"outside", 
			"over", 
			"own", 
			"p", 
			"past", 
			"pending", 
			"per", 
			"perhaps", 
			"plus", 
			"possible", 
			"present", 
			"probably", 
			"provided", 
			"providing", 
			"public", 
			"q", 
			"qua", 
			"quite", 
			"r", 
			"rather", 
			"re", 
			"real", 
			"really", 
			"respecting", 
			"right", 
			"round", 
			"s", 
			"same", 
			"sans", 
			"save", 
			"saving", 
			"second", 
			"several", 
			"shall", 
			"shalt", 
			"shan't", 
			"she", 
			"shed", 
			"shell", 
			"she's", 
			"short", 
			"should", 
			"shouldn't", 
			"since", 
			"six", 
			"small", 
			"so", 
			"some", 
			"somebody", 
			"someone", 
			"something", 
			"sometimes", 
			"soon", 
			"special", 
			"still", 
			"such", 
			"summat", 
			"supposing", 
			"sure", 
			"t", 
			"than", 
			"that", 
			"that'd", 
			"that'll", 
			"that's", 
			"the", 
			"thee", 
			"their", 
			"theirs", 
			"their's", 
			"them", 
			"themselves", 
			"then", 
			"there", 
			"there's", 
			"these", 
			"they", 
			"they'd", 
			"they'll", 
			"they're", 
			"they've", 
			"thine", 
			"this", 
			"tho", 
			"those", 
			"thou", 
			"though", 
			"three", 
			"thro'", 
			"through", 
			"throughout", 
			"thru", 
			"thyself", 
			"till", 
			"to", 
			"today", 
			"together", 
			"too", 
			"touching", 
			"toward", 
			"towards", 
			"true", 
			"'twas", 
			"'tween", 
			"'twere", 
			"'twill", 
			"'twixt", 
			"two", 
			"'twould", 
			"u", 
			"under", 
			"underneath", 
			"unless", 
			"unlike", 
			"until", 
			"unto", 
			"up", 
			"upon", 
			"us", 
			"used", 
			"usually", 
			"v", 
			"versus", 
			"very", 
			"via", 
			"vice", 
			"vis-a-vis", 
			"w", 
			"wanna", 
			"wanting", 
			"was", 
			"wasn't", 
			"way", 
			"we", 
			"we'd", 
			"well", 
			"were", 
			"weren't", 
			"wert", 
			"we've", 
			"what", 
			"whatever", 
			"what'll", 
			"what's", 
			"when", 
			"whencesoever", 
			"whenever", 
			"when's", 
			"whereas", 
			"where's", 
			"whether", 
			"which", 
			"whichever", 
			"whichsoever", 
			"while", 
			"whilst", 
			"who", 
			"who'd", 
			"whoever", 
			"whole", 
			"who'll", 
			"whom", 
			"whore", 
			"who's", 
			"whose", 
			"whoso", 
			"whosoever", 
			"will", 
			"with", 
			"within", 
			"without", 
			"wont", 
			"would", 
			"wouldn't", 
			"wouldst", 
			"x", 
			"y", 
			"ye", 
			"yet", 
			"you", 
			"you'd", 
			"you'll", 
			"your", 
			"you're", 
			"yours", 
			"yourself", 
			"yourselves", 
			"you've", 
			"z"

        };
        
        public static string[] StopWordsListNeg =
        {
            "a",
            "movi",
            "movie",
            "about",
            "above",
            "across",
            "afore",
            "aforesaid",
            "after",
            "again",
            "against",
            "agin",
            "ago",
            "aint",
            "albeit",
            "all",
            "almost",
            "alone",
            "along",
            "alongside",
            "already",
            "also",
            "although",
            "always",
            "am",
            "american",
            "amid",
            "amidst",
            "among",
            "amongst",
            "an",
            "and",
            "anent",
            "another",
            "any",
            "anybody",
            "anyone",
            "anything",
            "are",
            "aren't",
            "around",
            "as",
            "aslant",
            "astride",
            "at",
            "athwart",
            "away",
            "b",
            "back",
            "bar",
            "barring",
            "be",
            "because",
            "been",
            "before",
            "behind",
            "being",
            "below",
            "beneath",
            "beside",
            "besides",
            "best",
            "better",
            "between",
            "betwixt",
            "beyond",
            "both",
            "but",
            "by",
            "c",
            "can",
            "cannot",
            "can't",
            "certain",
            "circa",
            "close",
            "concerning",
            "considering",
            "cos",
            "could",
            "couldn't",
            "couldst",
            "d",
            "dare",
            "dared",
            "daren't",
            "dares",
            "daring",
            "despite",
            "did",
            "didn't",
            "different",
            "directly",
            "do",
            "does",
            "doesn't",
            "doing",
            "done",
            "don't",
            "dost",
            "doth",
            "down",
            "during",
            "durst",
            "e",
            "each",
            "early",
            "either",
            "em",
            "english",
            "enough",
            "ere",
            "even",
            "ever",
            "every",
            "everybody",
            "everyone",
            "everything",
            "except",
            "excepting",
            "f",
            "failing",
            "far",
            "few",
            "first",
            "five",
            "following",
            "for",
            "four",
            "from",
            "g",
            "gonna",
            "gotta",
            "h",
            "had",
            "hadn't",
            "hard",
            "has",
            "hasn't",
            "hast",
            "hath",
            "have",
            "haven't",
            "having",
            "he",
            "he'd",
            "he'll",
            "her",
            "here",
            "here's",
            "hers",
            "herself",
            "he's",
            "high",
            "him",
            "himself",
            "his",
            "home",
            "how",
            "howbeit",
            "however",
            "how's",
            "i",
            "id",
            "if",
            "ill",
            "i'm",
            "immediately",
            "important",
            "in",
            "inside",
            "instantly",
            "into",
            "is",
            "isn't",
            "it",
            "it'll",
            "it's",
            "its",
            "itself",
            "i've",
            "j",
            "just",
            "k",
            "l",
            "large",
            "last",
            "later",
            "least",
            "left",
            "less",
            "lest",
            "let's",
            "like",
            "likewise",
            "little",
            "living",
            "long",
            "m",
            "many",
            "may",
            "mayn't",
            "me",
            "mid",
            "midst",
            "might",
            "mightn't",
            "mine",
            "minus",
            "more",
            "most",
            "much",
            "must",
            "mustn't",
            "my",
            "myself",
            "n",
            "near",
            "'neath",
            "need",
            "needed",
            "needing",
            "needn't",
            "needs",
            "neither",
            "never",
            "nevertheless",
            "new",
            "next",
            "nigh",
            "nigher",
            "nighest",
            "nisi",
            "no",
            "no-one",
            "nobody",
            "none",
            "nor",
            "not",
            "nothing",
            "notwithstanding",
            "now",
            "o",
            "o'er",
            "of",
            "off",
            "often",
            "on",
            "once",
            "one",
            "oneself",
            "only",
            "onto",
            "open",
            "or",
            "other",
            "otherwise",
            "ought",
            "oughtn't",
            "our",
            "ours",
            "ourselves",
            "out",
            "outside",
            "over",
            "own",
            "p",
            "past",
            "pending",
            "per",
            "perhaps",
            "plus",
            "possible",
            "present",
            "probably",
            "provided",
            "providing",
            "public",
            "q",
            "qua",
            "quite",
            "r",
            "rather",
            "re",
            "real",
            "really",
            "respecting",
            "right",
            "round",
            "s",
            "same",
            "sans",
            "save",
            "saving",
            "second",
            "several",
            "shall",
            "shalt",
            "shan't",
            "she",
            "shed",
            "shell",
            "she's",
            "short",
            "should",
            "shouldn't",
            "since",
            "six",
            "small",
            "so",
            "some",
            "somebody",
            "someone",
            "something",
            "sometimes",
            "soon",
            "special",
            "still",
            "such",
            "summat",
            "supposing",
            "sure",
            "t",
            "than",
            "that",
            "that'd",
            "that'll",
            "that's",
            "the",
            "thee",
            "their",
            "theirs",
            "their's",
            "them",
            "themselves",
            "then",
            "there",
            "there's",
            "these",
            "they",
            "they'd",
            "they'll",
            "they're",
            "they've",
            "thine",
            "this",
            "tho",
            "those",
            "thou",
            "though",
            "three",
            "thro'",
            "through",
            "throughout",
            "thru",
            "thyself",
            "till",
            "to",
            "today",
            "together",
            "too",
            "touching",
            "toward",
            "towards",
            "true",
            "'twas",
            "'tween",
            "'twere",
            "'twill",
            "'twixt",
            "two",
            "'twould",
            "u",
            "under",
            "underneath",
            "unless",
            "unlike",
            "until",
            "unto",
            "up",
            "upon",
            "us",
            "used",
            "usually",
            "v",
            "versus",
            "very",
            "via",
            "vice",
            "vis-a-vis",
            "w",
            "wanna",
            "wanting",
            "was",
            "wasn't",
            "way",
            "we",
            "we'd",
            "well",
            "were",
            "weren't",
            "wert",
            "we've",
            "what",
            "whatever",
            "what'll",
            "what's",
            "when",
            "whencesoever",
            "whenever",
            "when's",
            "whereas",
            "where's",
            "whether",
            "which",
            "whichever",
            "whichsoever",
            "while",
            "whilst",
            "who",
            "who'd",
            "whoever",
            "whole",
            "who'll",
            "whom",
            "whore",
            "who's",
            "whose",
            "whoso",
            "whosoever",
            "will",
            "with",
            "within",
            "without",
            "wont",
            "would",
            "wouldn't",
            "wouldst",
            "x",
            "y",
            "ye",
            "yet",
            "you",
            "you'd",
            "you'll",
            "your",
            "you're",
            "yours",
            "yourself",
            "yourselves",
            "you've",
            "z",
            "able",
            "abst",
            "accordance",
            "according",
            "accordingly",
            "act",
            "actually",
            "added",
            "adj",
            "affected",
            "affecting",
            "affects",
            "afterwards",
            "ah",
            "announce",
            "anyhow",
            "anymore",
            "anyway",
            "anyways",
            "anywhere",
            "apparently",
            "approximately",
            "aren",
            "arent",
            "arise",
            "aside",
            "ask",
            "asking",
            "auth",
            "available",
            "awfully",
            "became",
            "become",
            "becomes",
            "becoming",
            "beforehand",
            "begin",
            "beginning",
            "beginnings",
            "begins",
            "believe",
            "biol",
            "brief",
            "briefly",
            "ca",
            "came",
            "cause",
            "causes",
            "certainly",
            "co",
            "com",
            "come",
            "comes",
            "contain",
            "containing",
            "contains",
            "couldnt",
            "date",
            "downwards",
            "due",
            "ed",
            "edu",
            "effect",
            "eg",
            "eight",
            "eighty",
            "else",
            "elsewhere",
            "end",
            "ending",
            "especially",
            "et",
            "et-al",
            "etc",
            "everywhere",
            "ex",
            "ff",
            "fifth",
            "fix",
            "followed",
            "follows",
            "former",
            "formerly",
            "forth",
            "found",
            "further",
            "furthermore",
            "gave",
            "get",
            "gets",
            "getting",
            "give",
            "given",
            "gives",
            "giving",
            "go",
            "goes",
            "gone",
            "got",
            "gotten",
            "happens",
            "hardly",
            "hed",
            "hence",
            "hereafter",
            "hereby",
            "herein",
            "heres",
            "hereupon",
            "hes",
            "hi",
            "hid",
            "hither",
            "hundred",
            "ie",
            "i'll",
            "im",
            "immediate",
            "importance",
            "inc",
            "indeed",
            "index",
            "information",
            "instead",
            "invention",
            "inward",
            "itd",
            "keep	keeps",
            "kept",
            "kg",
            "km",
            "know",
            "known",
            "knows",
            "largely",
            "lately",
            "latter",
            "latterly",
            "let",
            "lets",
            "liked",
            "likely",
            "line",
            "'ll",
            "look",
            "looking",
            "looks",
            "ltd",
            "made",
            "mainly",
            "make",
            "makes",
            "maybe",
            "mean",
            "means",
            "meantime",
            "meanwhile",
            "merely",
            "mg",
            "million",
            "miss",
            "ml",
            "moreover",
            "mostly",
            "mr",
            "mrs",
            "mug",
            "na",
            "name",
            "namely",
            "nay",
            "nd",
            "nearly",
            "necessarily",
            "necessary",
            "nine",
            "ninety",
            "non",
            "nonetheless",
            "noone",
            "normally",
            "nos",
            "noted",
            "nowhere",
            "obtain",
            "obtained",
            "obviously",
            "oh",
            "ok",
            "okay",
            "old",
            "omitted",
            "ones",
            "ord",
            "others",
            "overall",
            "owing",
            "page",
            "pages",
            "part",
            "particular",
            "particularly",
            "placed",
            "please",
            "poorly",
            "possibly",
            "potentially",
            "pp",
            "predominantly",
            "previously",
            "primarily",
            "promptly",
            "proud",
            "provides",
            "put",
            "que",
            "quickly",
            "qv",
            "ran",
            "rd",
            "readily",
            "recent",
            "recently",
            "ref",
            "refs",
            "regarding",
            "regardless",
            "regards",
            "related",
            "relatively",
            "research",
            "respectively",
            "resulted",
            "resulting",
            "results",
            "run",
            "said",
            "saw",
            "say",
            "saying",
            "says",
            "sec",
            "section",
            "see",
            "seeing",
            "seem",
            "seemed",
            "seeming",
            "seems",
            "seen",
            "self",
            "selves",
            "sent",
            "seven",
            "she'll",
            "shes",
            "show",
            "showed",
            "shown",
            "showns",
            "shows",
            "significant",
            "significantly",
            "similar",
            "similarly",
            "slightly",
            "somehow",
            "somethan",
            "sometime",
            "somewhat",
            "somewhere",
            "sorry",
            "specifically",
            "specified",
            "specify",
            "specifying",
            "stop",
            "strongly",
            "sub",
            "substantially",
            "successfully",
            "sufficiently",
            "suggest",
            "longer"	,
            "sea"	,
            "rescu"	,
            "sequenc"	,
            "charact"	,
            "realiz"	,
            "time"	,
            "kid"	,
            "think"	,
            "sign"	,
            "appear"	,
            "win"	,
            "tell"	,
            "told"	,
            "whi"	,
            "driven"	,
            "magic"	,
            "keep"	,
            "turn"	,
            "action"	,
            "film"	,
            "watch"	,
            "wast"	,
            "ice"	,
            "cube"	,
            "ve"	,
            "capabl"	,
            "act"	,
            "don"	,
            "jack"	,
            "citi"	,
            "york"	,
            "boyz"	,
            "hood"	,
            "higher"	,
            "friday"	,
            "deal"	,
            "grate"	,
            "teeth"	,
            "wonder"	,
            "play"	,
            "exact"	,
            "alien"	,
            "night"	,
            "carbon"	,
            "copi"	,
            "script"	,
            "thing"	,
            "hand"	,
            "camera"	,
            "refresh"	,
            "make"	,
            "number"	,
            "nt"	,
            "press"	,
            "forehead"	,
            "curs"	,
            "shoot"	,
            "version"	,
            "minut"	,
            "explain"	,
            "go"	,
            "singl"	,
            "guy"	,
            "brain"	,
            "william"	,
            "sadler"	,
            "hill"	,
            "billi"	,
            "villain"	,
            "start"	,
            "fill"	,
            "pointless"	,
            "specialti"	,
            "peopl"	,
            "fall"	,
            "window"	,
            "glass"	,
            "fli"	,
            "pretti"	,
            "plot"	,
            "big"	,
            "root"	,
            "deserv"	,
            "actor"	,
            "profess"	,
            "stay"	,
            "sens"	,
            "humor"	,
            "cast"	,
            "song"	,
            "mop"	,
            "top"	,
            "movi"	,
            "social"	,
            "platform"	,
            "music"	,
            "star"	,
            "full"	,
            "swing"	,
            "took"	,
            "seat"	,
            "man"	,
            "region"	,
            "accent"	,
            "transpar"	,
            "love"	,
            "cring"	,
            "firemen"	,
            "live"	,
            "build"	,
            "tenant"	,
            "flame"	,
            "map"	,
            "gold"	,
            "set"	,
            "main"	,

            "sup"

        };
    }
}
