using Leetcode;

namespace TestLeetCode;

public class TestSolution843
{
    [Fact]
    public void TestCase1()
    {
        string[] wordList = {"acckzz", "ccbazz", "eiowzz", "abcczz"};
        var allowedGuesses = 10;

        var master = new Solution843.Master("acckzz", wordList);
        Solution843.FindSecretWord(wordList, master);

        Assert.True(master.Call < allowedGuesses);
    }

    [Fact]
    public void TestCase2()
    {
        string[] wordList = {"hamada", "khaled"};
        var allowedGuesses = 10;

        var master = new Solution843.Master("hamada", wordList);
        Solution843.FindSecretWord(wordList, master);

        Assert.True(master.Call < allowedGuesses);
    }

    [Fact]
    public void TestCase3()
    {
        string[] wordList =
        {
            "gaxckt", "trlccr", "jxwhkz", "ycbfps",
            "peayuf", "yiejjw", "ldzccp", "nqsjoa", "qrjasy", "pcldos",
            "acrtag", "buyeia", "ubmtpj", "drtclz", "zqderp", "snywek",
            "caoztp", "ibpghw", "evtkhl", "bhpfla", "ymqhxk", "qkvipb",
            "tvmued", "rvbass", "axeasm", "qolsjg", "roswcb", "vdjgxx",
            "bugbyv", "zipjpc", "tamszl", "osdifo", "dvxlxm", "iwmyfb",
            "wmnwhe", "hslnop", "nkrfwn", "puvgve", "rqsqpq", "jwoswl",
            "tittgf", "evqsqe", "aishiv", "pmwovj", "sorbte", "hbaczn",
            "coifed", "hrctvp", "vkytbw", "dizcxz", "arabol", "uywurk",
            "ppywdo", "resfls", "tmoliy", "etriev", "oanvlx", "wcsnzy",
            "loufkw", "onnwcy", "novblw", "mtxgwe", "rgrdbt", "ckolob",
            "kxnflb", "phonmg", "egcdab", "cykndr", "lkzobv", "ifwmwp",
            "jqmbib", "mypnvf", "lnrgnj", "clijwa", "kiioqr", "syzebr",
            "rqsmhg", "sczjmz", "hsdjfp", "mjcgvm", "ajotcx", "olgnfv",
            "mjyjxj", "wzgbmg", "lpcnbj", "yjjlwn", "blrogv", "bdplzs",
            "oxblph", "twejel", "rupapy", "euwrrz", "apiqzu", "ydcroj",
            "ldvzgq", "zailgu", "xgqpsr", "wxdyho", "alrplq", "brklfk"
        };
        var allowedGuesses = 10;

        var master = new Solution843.Master("hbaczn", wordList);
        Solution843.FindSecretWord(wordList, master);

        Assert.True(master.Call < allowedGuesses);
    }

    [Fact]
    public void TestCase4()
    {
        string[] wordList =
        {
            "aaaaga", "aaaaka", "aaauaa", "aaaaoa", "aafaaa", "aaaaza", "aaaava", "agaaaa", "aaagaa", "aaaaqa",
            "aaaaca", "aaaaua", "apaaaa", "aawaaa", "aaaaba", "aaaqaa", "aayaaa", "aaaaja", "aaacaa", "aaayaa",
            "aaaeaa", "aavaaa", "aasaaa", "aaaapa", "aaaaxa", "aeaaaa", "aaxaaa", "akaaaa", "aaaoaa", "aazaaa",
            "anaaaa", "aaaala", "aaraaa", "aaaata", "aaaaia", "ajaaaa", "aaaaaa", "ahaaaa", "aaaraa", "aaaiaa",
            "aanaaa", "alaaaa", "aakaaa", "aiaaaa", "aajaaa", "aaakaa", "axaaaa", "aaqaaa", "aaamaa", "aapaaa",
            "aaafaa", "aaasaa", "aadaaa", "amaaaa", "aaaaea", "aabaaa", "aaaama", "asaaaa", "acaaaa", "aaiaaa",
            "avaaaa", "afaaaa", "aoaaaa", "aamaaa", "aaaasa", "aaawaa", "azaaaa", "aataaa", "aaeaaa", "aaaafa",
            "aaahaa", "aaalaa", "aaaana", "aaanaa", "aaabaa", "aaaada", "auaaaa", "aaapaa", "awaaaa", "ayaaaa",
            "adaaaa", "aaavaa", "aagaaa", "aauaaa", "abaaaa", "aaadaa", "aqaaaa", "aaaxaa", "aaaawa", "aaajaa",
            "araaaa", "aahaaa", "aaaaha", "aacaaa", "aaaara", "aaoaaa", "ataaaa", "aaaaya", "aalaaa", "aaazaa"
        };
        var allowedGuesses = 10;

        var master = new Solution843.Master("hbaczn", wordList);
        Solution843.FindSecretWord(wordList, master);

        Assert.True(master.Call < allowedGuesses);
    }
}