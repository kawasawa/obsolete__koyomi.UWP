﻿namespace Koyomi.Common
{
    /// <summary>
    /// 四季を定義します。
    /// </summary>
    public enum FourSeasonKind
    {
        春,
        夏,
        秋,
        冬,
    }

    /// <summary>
    /// 節月を定義します。
    /// </summary>
    public enum SetsugetsuKind
    {
        正月 = 1,
        二月 = 2,
        三月 = 3,
        四月 = 4,
        五月 = 5,
        六月 = 6,
        七月 = 7,
        八月 = 8,
        九月 = 9,
        十月 = 10,
        十一月 = 11,
        十二月 = 12,
    }

    /// <summary>
    /// 二十四節気を定義します。
    /// </summary>
    public enum SolarTermKind
    {
        小寒,
        大寒,
        立春,
        雨水,
        啓蟄,
        春分,
        清明,
        穀雨,
        立夏,
        小満,
        芒種,
        夏至,
        小暑,
        大暑,
        立秋,
        処暑,
        白露,
        秋分,
        寒露,
        霜降,
        立冬,
        小雪,
        大雪,
        冬至,
    }

    /// <summary>
    /// 気候の種類を定義します。
    /// </summary>
    public enum ClimateKind
    {
        初侯,
        次侯,
        末侯,
    }

    /// <summary>
    /// 七十二候の種類を定義します。
    /// </summary>
    public enum SolarTermMicroKind
    {
        雪下出麦,
        芹乃栄,
        水泉動,
        雉始雊,
        款冬華,
        水沢腹堅,
        鶏始乳,
        東風解凍,
        黄鶯睍睆,
        魚上氷,
        土脉潤起,
        霞始靆,
        草木萌動,
        蟄虫啓戸,
        桃始笑,
        菜虫化蝶,
        雀始巣,
        桜始開,
        雷乃発声,
        玄鳥至,
        鴻雁北,
        虹始見,
        葭始生,
        霜止出苗,
        牡丹華,
        蛙始鳴,
        蚯蚓出,
        竹笋生,
        蚕起食桑,
        紅花栄,
        麦秋至,
        螳螂生,
        腐草為蛍,
        梅子黄,
        乃東枯,
        菖蒲華,
        半夏生,
        温風至,
        蓮始開,
        鷹乃学習,
        桐始結花,
        土潤溽暑,
        大雨時行,
        涼風至,
        寒蝉鳴,
        蒙霧升降,
        綿柎開,
        天地始粛,
        禾乃登,
        草露白,
        鶺鴒鳴,
        玄鳥去,
        雷乃収声,
        蟄虫坏戸,
        水始涸,
        鴻雁来,
        菊花開,
        蟋蟀在戸,
        霜始降,
        霎時施,
        楓蔦黄,
        山茶始開,
        地始凍,
        金盞香,
        虹蔵不見,
        朔風払葉,
        橘始黄,
        閉塞成冬,
        熊蟄穴,
        鱖魚群,
        乃東生,
        麋角解,
    }

    /// <summary>
    /// 和風月名の種類を定義します。
    /// </summary>
    public enum JpMonthKind
    {
        睦月 = 0,
        如月 = 1,
        弥生 = 2,
        卯月 = 3,
        皐月 = 4,
        水無月 = 5,
        文月 = 6,
        葉月 = 7,
        長月 = 8,
        神無月 = 9,
        霜月 = 10,
        師走 = 11,
    }

    /// <summary>
    /// 日本における曜日の種類を定義します。
    /// </summary>
    public enum JpDayOfWeekKind
    {
        日,
        月,
        火,
        水,
        木,
        金,
        土,
    }

    /// <summary>
    /// 十二星座を定義します。
    /// </summary>
    public enum StarSignKind
    {
        水瓶座,
        魚座,
        牡羊座,
        牡牛座,
        双子座,
        蟹座,
        獅子座,
        乙女座,
        天秤座,
        蠍座,
        射手座,
        山羊座,
    }

    /// <summary>
    /// 十二支の種類を定義します。
    /// </summary>
    public enum JunishiKind
    {
        子 = 0,
        丑 = 1,
        寅 = 2,
        卯 = 3,
        辰 = 4,
        巳 = 5,
        午 = 6,
        未 = 7,
        申 = 8,
        酉 = 9,
        戌 = 10,
        亥 = 11,
    }

    /// <summary>
    /// 十干の種類を定義します。
    /// </summary>
    public enum JikkanKind
    {
        甲 = 0,
        乙 = 1,
        丙 = 2,
        丁 = 3,
        戊 = 4,
        己 = 5,
        庚 = 6,
        辛 = 7,
        壬 = 8,
        癸 = 9,
    }

    /// <summary>
    /// 六曜の種類を定義します。
    /// </summary>
    public enum RokuyoKind
    {
        大安 = 0,
        赤口 = 1,
        先勝 = 2,
        友引 = 3,
        先負 = 4,
        仏滅 = 5,
    }

    /// <summary>
    /// 十二直の種類を定義します。
    /// </summary>
    public enum JunichokuKind
    {
        建 = 0,
        除 = 1,
        満 = 2,
        平 = 3,
        定 = 4,
        執 = 5,
        破 = 6,
        危 = 7,
        成 = 8,
        納 = 9,
        開 = 10,
        閉 = 11,
    }

    /// <summary>
    /// 二十七宿の種類を定義します。
    /// </summary>
    public enum NijunanashukuKind
    {
        角 = 0,
        亢 = 1,
        氐 = 2,
        房 = 3,
        心 = 4,
        尾 = 5,
        箕 = 6,
        斗 = 7,
        女 = 8,
        虚 = 9,
        危 = 10,
        室 = 11,
        壁 = 12,
        奎 = 13,
        婁 = 14,
        胃 = 15,
        昴 = 16,
        畢 = 17,
        觜 = 18,
        参 = 19,
        井 = 20,
        鬼 = 21,
        柳 = 22,
        星 = 23,
        張 = 24,
        翼 = 25,
        軫 = 26,
    }

    /// <summary>
    /// 二十八宿の種類を定義します。
    /// </summary>
    public enum NijuhashukuKind
    {
        角 = 0,
        亢 = 1,
        氐 = 2,
        房 = 3,
        心 = 4,
        尾 = 5,
        箕 = 6,
        斗 = 7,
        牛 = 8,
        女 = 9,
        虚 = 10,
        危 = 11,
        室 = 12,
        壁 = 13,
        奎 = 14,
        婁 = 15,
        胃 = 16,
        昴 = 17,
        畢 = 18,
        觜 = 19,
        参 = 20,
        井 = 21,
        鬼 = 22,
        柳 = 23,
        星 = 24,
        張 = 25,
        翼 = 26,
        軫 = 27,
    }

    /// <summary>
    /// 九星の種類を定義します。
    /// </summary>
    public enum KyuseiKind
    {
        一白水星 = 0,
        二黒土星 = 1,
        三碧木星 = 2,
        四緑木星 = 3,
        五黄土星 = 4,
        六白金星 = 5,
        七赤金星 = 6,
        八白土星 = 7,
        九紫火星 = 8,
    }
}