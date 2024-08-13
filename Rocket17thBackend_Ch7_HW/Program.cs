using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket17thBackend_Ch7_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //檔案處理題目


            //1. 寫一篇中文歌的歌詞到到自己指定的文字檔(使用UTF - 8編碼)。

            //Console.WriteLine("1. 寫一篇中文歌的歌詞到到自己指定的文字檔(使用UTF - 8編碼)。");

            //Console.WriteLine("寫一篇中文歌詞到指定路徑產生文字檔(.txt)");

            //Console.WriteLine("參考路徑: " + @"C:\Users\MyDocumet\lyrics.txt");
            //Console.Write("請指定路徑: ");

            //String path = Console.ReadLine();

            //Console.WriteLine($"\n指定輸入路徑為: {path}");

            //Console.Write("\n 請輸入歌詞有幾句: ");

            //int lyricsLines = Convert.ToInt32( Console.ReadLine() );

            //Console.WriteLine("請依序、連續輸入歌詞: ");
            //Console.WriteLine();

            //string[] lyrics = new string[lyricsLines];

            //for (int i = 0; i < lyrics.Length; i++)
            //{
            //    lyrics[i] = Console.ReadLine();
            //}

            //File.WriteAllLines(path, lyrics, Encoding.UTF8);

            //Console.WriteLine("\n寫入完成");

            //Console.ReadKey();

            //----------------------------------------------------------------------------------------

            //2. 讀取1.txt 顯示在畫面上。

            //Console.WriteLine("2. 讀取1.txt 顯示在畫面上");

            //Console.WriteLine("請輸入讀取檔案之路徑");
            //Console.WriteLine(@"路徑如: C:\Users\frank\OneDrive\桌面\火箭隊17th\backend\hw\testfile\1.txt");
            //Console.Write("指定路徑: ");

            //string path = Console.ReadLine();

            //string[] showOnConsole = File.ReadAllLines(path);

            //Console.WriteLine();

            //foreach (string line in showOnConsole) 
            //{
            //    Console.WriteLine(line);
            //}

            //Console.ReadKey();
            //----------------------------------------------------------------------------------------

            //檔案處理補充練習題

            //1. 寫入九九乘法表資料到一個文字檔到自己指定的文字檔。

            //Console.WriteLine("1. 寫入九九乘法表資料到一個文字檔到自己指定的文字檔。");

            //Console.Write("請輸入要輸出九九乘法表文字檔的路徑: ");
            //Console.WriteLine(@"路徑如: C:\Users\frank\OneDrive\桌面\火箭隊17th\backend\hw\testfile\9x9乘法表.txt");
            //Console.Write("請輸入路徑: ");
            ////string path = @"C:\Users\frank\OneDrive\桌面\火箭隊17th\backend\hw\testfile\9x9乘法表.txt"; //測試路徑
            //string path = Console.ReadLine();

            //int row = 9;
            //int col = 9;

            //string[] multiplication_table = new string[row*col];

            //int tmp = 0;
            //for (int i = 1; i < row+1; i+=3) {

            //    for (int j = 1; j < col+1; j++)
            //    {
            //        //int tmp = 9 * (i - 1) + j-1; //陣列從[0]開始

            //        multiplication_table[tmp] = $"{i}x{j}={i*j}\t{i+1}x{j}={(i+1) * j}\t{i + 2}x{j}={(i + 2) * j}";
            //        tmp++;

            //    }
            //    tmp++;
            //    multiplication_table[tmp] = "";
            //}

            //File.WriteAllLines(path, multiplication_table);

            //Console.WriteLine($"已輸出到指定位置 {path}");

            //Console.ReadKey();
            //----------------------------------------------------------------------------------------
            //2. 讀取1.txt 顯示在畫面上，並將1.txt 裡的阿拉伯數字，轉換成中文數字(壹、貳、叁、肆…..)，並儲存到指定的路徑。(UTF - 8)

            //Console.WriteLine("2. 讀取1.txt 顯示在畫面上，並將1.txt 裡的阿拉伯數字，轉換成中文數字(壹、貳、叁、肆…..)，並儲存到指定的路徑。(UTF - 8)");

            //Console.WriteLine("請輸入讀取檔案之路徑");
            //Console.WriteLine(@"路徑如: C:\Users\frank\OneDrive\桌面\火箭隊17th\backend\hw\testfile\1.txt" + "\n");
            //Console.Write("指定路徑: ");

            //string pathInput = Console.ReadLine();

            //string[] fileLoad = File.ReadAllLines(pathInput);

            //foreach (string line in fileLoad)
            //{
            //    Console.WriteLine(line);
            //}

            //Console.WriteLine("\n請輸入輸出檔案之路徑");
            //Console.WriteLine(@"路徑如: C:\Users\frank\OneDrive\桌面\火箭隊17th\backend\hw\testfile\1_轉換後.txt" + "\n");
            //Console.Write("指定路徑: ");

            //string pathOutput = Console.ReadLine();

            //string[] fileOutput = fileLoad;

            //string[] numbers = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            //string[] numbersInChinese = new string[10] { "零", "壹", "貳", "參", "肆", "伍", "陸", "柒", "捌", "玖" };

            //for (int i = 0; i < fileLoad.Length; i++)
            //{
            //    for (int j = 0; j < numbers.Length; j++)
            //    {
            //        fileOutput[i] = fileOutput[i].Replace(numbers[j], numbersInChinese[j]);
            //    }
            //}

            //File.WriteAllLines(pathOutput, fileOutput, Encoding.UTF8);

            //Console.WriteLine("\n轉換阿拉伯數字為中文數字後\n");

            //foreach (string LineOutput in fileOutput)
            //{
            //    Console.WriteLine(LineOutput);
            //}


            //Console.ReadKey();
            //----------------------------------------------------------------------------------------

            //3. 讀取fc4bb.csv，並將此資料轉成HTML TABLE 格式，並儲存到指定的HTML檔裡。

            //Console.WriteLine("3. 讀取fc4bb.csv，並將此資料轉成HTML TABLE 格式，並儲存到指定的HTML檔裡。");

            //Console.WriteLine("請輸入讀取檔案之路徑");
            //Console.WriteLine(@"路徑如: C:\Users\frank\OneDrive\桌面\火箭隊17th\backend\hw\testfile\fc4bb.csv" + "\n");
            //Console.Write("指定路徑: ");
            //string pathInput = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("請輸入輸出檔案之路徑");
            //Console.WriteLine(@"路徑如: C:\Users\frank\OneDrive\桌面\火箭隊17th\backend\hw\testfile\output.html" + "\n");
            //Console.Write("指定路徑: ");

            //string pathHTML = Console.ReadLine();

            //string[] tableDataLines = File.ReadAllLines(pathInput);

            //string contentHTML;

            //contentHTML = "<html><body><table>";

            //foreach (string tableDataLine in tableDataLines) 
            //{
            //    contentHTML += "<tr>";

            //    string[] columns = tableDataLine.Split(',');

            //    foreach (string column in columns) {
            //        contentHTML = contentHTML.Insert(contentHTML.Length,$"<td>{column}</td>");                
            //    }

            //    contentHTML += "</tr>";

            //}

            //contentHTML += "</table></body></html>";

            //File.WriteAllText(pathHTML, contentHTML, Encoding.UTF8);

            //Console.WriteLine($"\nhtml table已輸出至指定位址: {pathHTML}");

            //Console.ReadKey();

            //----------------------------------------------------------------------------------------


            //亂數

            //1. 請隨機由0~99產生一個數字輸出。
            //Random rom = new Random();//亂數種子int I = rom.Next(0, 100);//回傳0-99的亂數

            //Console.WriteLine("1. 請隨機由0~99產生一個數字輸出。");

            //Random Rom = new Random();
            //int x = Rom.Next(0,100);

            //Console.WriteLine($"隨機由0~99產生一個數字: {x}");

            //Console.ReadKey();
            //----------------------------------------------------------------------------------------
            //2. 請隨機由0~99產生10個數字輸出。

            //Console.WriteLine("2. 請隨機由0~99產生10個數字輸出。");

            //int round = 10;
            //int min, max;

            //Random rom = new Random();
            //min = 0;
            //max = 100; 


            //for (int i = 0; i < round; i++) {
            //    Console.WriteLine($"第{i+1}個隨機數字: {rom.Next(min,max)}");
            //}

            //Console.ReadKey();
            //----------------------------------------------------------------------------------------
            //3. 隨機幫每位學員產生成績，並寫入文字檔(欄位之間用，分開，換行寫入下一筆)。

            //Console.WriteLine("3. 隨機幫每位學員產生成績，並寫入文字檔(欄位之間用，分開，換行寫入下一筆)。");

            //Console.Write("請輸入有幾位學生: ");
            //int numOfStudent = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("請輸入要輸出的成績檔案路徑 ");
            //Console.WriteLine(@"路徑如: C:\Users\frank\OneDrive\桌面\火箭隊17th\backend\hw\testfile\學生成績.txt" + "\n");
            //Console.Write("請輸入路徑: ");

            //string pathOutput = Console.ReadLine();

            //Random  scoreRom = new Random();

            //string[] score = new string[numOfStudent];

            //for (int i = 0; i < numOfStudent; i++) {
            //    score[i] = $"第{i+1}位學生的成績，{scoreRom.Next(0, 101)}\n";
            //}

            //File.WriteAllLines(pathOutput, score);

            //Console.WriteLine($"檔案已輸出到: {pathOutput}");

            //Console.ReadKey();
            //----------------------------------------------------------------------------------------

            //亂數補充題

            //1. 請設計樂透開獎程式。

            //Console.WriteLine("1. 請設計樂透開獎程式。");

            //Console.Write("請輸入需要幾個樂透數字: ");
            //int count = Convert.ToInt32(Console.ReadLine());

            //Console.Write("請輸入範圍下限(包含該數字): ");
            //int min = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入範圍上限(包含該數字): ");
            //int max = Convert.ToInt32(Console.ReadLine());

            //Random  lottery = new Random();

            //for (int i = 0; i < count; i++) {
            //    Console.WriteLine($"第{i+1}個樂透數字: {lottery.Next(min,max+1)}");
            //}

            //Console.ReadKey();
            //----------------------------------------------------------------------------------------
            //2. 請在文字檔裡輸入所有午餐的店家，讀取文字檔，隨機抽出今天中午要吃哪一家。

            //Console.WriteLine("2. 請在文字檔裡輸入所有午餐的店家，讀取文字檔，隨機抽出今天中午要吃哪一家");

            //Console.WriteLine("請輸入午餐店家清單檔案指定路徑: ");
            //Console.WriteLine(@"路徑如: C:\Users\frank\OneDrive\桌面\火箭隊17th\backend\hw\testfile\restaurantList.txt" + "\n");
            //Console.Write("請輸入路徑: ");
            //string path = Console.ReadLine();

            //string[] restaurantList = File.ReadAllLines(path);

            //Random rom = new Random();

            //string restaurantChoosed = restaurantList[rom.Next(0, restaurantList.Length + 1)];

            //Console.WriteLine($"今日隨選餐廳為: {restaurantChoosed}");

            //Console.ReadKey();
            //----------------------------------------------------------------------------------------
            //3. 請在文字檔裡輸入所有教室裡的學員名字，讀取文字檔，隨機抽出今天的值日生，抽過不能再被抽中，直到全部學員都被抽過，才可以再被抽。

            //Console.WriteLine("3. 請在文字檔裡輸入所有教室裡的學員名字，讀取文字檔，隨機抽出今天的值日生，抽過不能再被抽中，直到全部學員都被抽過，才可以再被抽。");


            //Console.WriteLine("請輸入學員清單之指定讀取位址");
            //Console.WriteLine(@"路徑如: C:\Users\frank\OneDrive\桌面\火箭隊17th\backend\hw\testfile\StudnetList.txt" + "\n");
            //Console.Write("請輸入路徑: ");
            //string pathStudnetList = Console.ReadLine();

            //string[] studentList = File.ReadAllLines(pathStudnetList);

            //Console.WriteLine("studentList: \n");
            //foreach (string student in studentList) {
            //    Console.WriteLine(student);
            //}

            //Console.WriteLine();

            //Console.WriteLine("請輸入已輪值過的學生清單之指定讀取位址");
            //Console.WriteLine(@"路徑如: C:\Users\frank\OneDrive\桌面\火箭隊17th\backend\hw\testfile\DutyHistory.txt" + "\n");
            //Console.Write("請輸入路徑: ");
            //string pathDutyHistory = Console.ReadLine();

            ////如果有輸入路徑，使用路徑檔案；沒路徑就歸零

            //string[] dutyHistory;

            //dutyHistory = File.ReadAllLines(pathDutyHistory);

            //Console.WriteLine("\n已經當過的人: \n");
            //foreach (string duty in dutyHistory)
            //{
            //    Console.WriteLine(duty);
            //}

            //Console.WriteLine();


            ////比對清單找出還沒當過值日生的學生，輸入待選清單

            //string[] unselectedList = new string[studentList.Length]; //待選清單宣告
            //int unselectedCount = 0; //待選學生數 for 標記和random限制範圍

            //for (int i = 0; i < studentList.Length; i++) {

            //    if (IsRepeat(studentList[i], dutyHistory) == false) {
            //        unselectedList[unselectedCount]=studentList[i];
            //        unselectedCount++;
            //    }

            //    //Console.WriteLine("新的unselectedList: "); //to check array
            //    //foreach (string unduty in unselectedList) { Console.WriteLine(unduty); }  //to check array

            //}

            //if (unselectedCount == 0 )  //全部人都當過了，初始化History
            //{
            //    unselectedList = studentList;
            //    unselectedCount = studentList.Length;
            //    Array.Clear(dutyHistory,0, dutyHistory.Length);
            //}

            //Random rom = new Random();

            //string onDutyToday = unselectedList[rom.Next(0, unselectedCount)];
            //Console.WriteLine($"今天的值日生是: {onDutyToday}");

            ////更新history，檔案生成覆蓋的方式處理

            //Console.WriteLine("新的已當過值日生清單已覆蓋原清單");

            //string[] dutyHistorynew = new string[dutyHistory.Length+1];

            //dutyHistory.CopyTo(dutyHistorynew,0);


            //dutyHistorynew[dutyHistory.Length] = onDutyToday;

            //File.WriteAllLines(pathDutyHistory, dutyHistorynew);

            //Console.WriteLine($"已輸出至原清單位置: {pathDutyHistory}");

            //Console.WriteLine("\n已當過的人有:");
            //foreach (string onduty in dutyHistorynew)
            //{
            //    Console.WriteLine(onduty);
            //}

            //Console.ReadKey();
            //----------------------------------------------------------------------------------------


            //日期題目

            //1. 顯示現在日期與時間。

            //Console.WriteLine("1. 顯示現在日期與時間");

            //DateTime now = DateTime.Now;
            //Console.WriteLine($"現在日期與時間為 {now.Year}年 {now.Month}月 {now.Day}日 {now.Hour}時:{now.Minute}分:{now.Second}秒");

            //Console.ReadKey();
            //----------------------------------------------------------------------------------------
            //2.顯示再過30天為哪一天。

            //Console.WriteLine("2.顯示再過30天為哪一天");

            //DateTime today = DateTime.Today;
            //Console.WriteLine($"現在時間為: {today.Year}年{today.Month}月{today.Day}日");

            //DateTime todayAdd30D = today.AddDays(30);
            //Console.WriteLine($"過了30天後為: {todayAdd30D.Year}年{todayAdd30D.Month}月{todayAdd30D.Day}日");

            //Console.ReadKey();
            //----------------------------------------------------------------------------------------
            //3.顯示24小時前的年月日時分秒。

            //Console.WriteLine("3.顯示24小時前的年月日時分秒");
            //DateTime now = DateTime.Now;
            //Console.WriteLine($"現在日期與時間為: {now.Year}年 {now.Month}月 {now.Day}日 {now.Hour}時:{now.Minute}分:{now.Second}秒");

            //DateTime past24H = now.AddHours(-24);

            //Console.WriteLine($"24小時前為:       {past24H.Year}年 {past24H.Month}月 {past24H.Day}日 {past24H.Hour}時:{past24H.Minute}分:{past24H.Second}秒");

            //Console.ReadKey();
            //----------------------------------------------------------------------------------------
            //4.取得目前是幾月。

            //Console.WriteLine("4.取得目前是幾月。");

            //DateTime now = DateTime .Now;

            //Console.WriteLine($"目前是 {now.Month}月");

            //Console.ReadKey();
            //----------------------------------------------------------------------------------------
            //5.取得明年是否為閏年。(可以試試民國)

            //Console.WriteLine("5.取得明年是否為閏年。(可以試試民國)");

            //DateTime now = DateTime.Now;

            //DateTime nextYear = now.AddYears(1);
            //bool isLeapYear = DateTime.IsLeapYear(nextYear.Year);

            //Console.WriteLine($"明年( 民國 {nextYear.Year -1911}年) 是不是閏年: {isLeapYear}");

            //Console.ReadKey();
            //----------------------------------------------------------------------------------------
            //6.取得離2025年1月1日還有幾天。

            //Console.WriteLine("6.取得離2025年1月1日還有幾天");

            //DateTime now = DateTime.Now;

            //DateTime target = new DateTime(2025, 1, 1);

            //int durationDay = (int)(target - now).TotalDays;
            //Console.WriteLine($"今天是{now:yyyy年MM月dd日}，距離 {target:yyyy年MM月dd日} 還有 {durationDay} 天");

            //Console.ReadKey();
            //----------------------------------------------------------------------------------------
            //日期補充題

            //1.星期一，猴子穿新衣，
            //星期二，猴子肚子餓，
            //星期三，猴子去爬山，
            //星期四，猴子看電視，
            //呈期五，猴子去跳舞，
            //星期六，猴子去斗六，
            //星期日，猴子過生日。
            //請顯示今天猴子做甚麼事。

            //Console.WriteLine("1.星期一，猴子穿新衣，\r\n星期二，猴子肚子餓，\r\n星期三，猴子去爬山，\r\n星期四，猴子看電視，\r\n呈期五，猴子去跳舞，\r\n星期六，猴子去斗六，\r\n星期日，猴子過生日。\r\n請顯示今天猴子做甚麼事。\n");

            //DateTime now = DateTime.Now;

            //Console.WriteLine($"今天是 {now.Date}， {now.DayOfWeek}");


            //switch (now.DayOfWeek)
            //{

            //    case DayOfWeek.Monday:
            //        Console.WriteLine("星期一，猴子穿新衣");
            //        break;
            //    case DayOfWeek.Tuesday:
            //        Console.WriteLine("星期二，猴子肚子餓");
            //        break;
            //    case DayOfWeek.Wednesday:
            //        Console.WriteLine("星期三，猴子去爬山");
            //        break;
            //    case DayOfWeek.Thursday:
            //        Console.WriteLine("星期四，猴子看電視");
            //        break;
            //    case DayOfWeek.Friday:
            //        Console.WriteLine("呈期五，猴子去跳舞");
            //        break;
            //    case DayOfWeek.Saturday:
            //        Console.WriteLine("星期六，猴子去斗六");
            //        break;
            //    case DayOfWeek.Sunday:
            //        Console.WriteLine("星期日，猴子過生日。");
            //        break;
            //    default:
            //        Console.WriteLine("格式錯誤"); ;
            //        break;
            //}


            //Console.ReadKey();
            //----------------------------------------------------------------------------------------
            //2.輸入‘兩個日期，輸出兩個日期相差幾天。

            //Console.WriteLine("2.輸入‘兩個日期，輸出兩個日期相差幾天");

            //Console.WriteLine("請輸入第一個日期 (yyyy/MM/dd):");
            //DateTime firstday = DateTime.Parse(Console.ReadLine());

            //Console.WriteLine("請輸入第二個日期 (yyyy/MM/dd):");
            //DateTime secondDay = DateTime.Parse(Console.ReadLine());

            //TimeSpan duration = secondDay - firstday;
            //Console.WriteLine($"兩個日期相差 {duration.Days} 天");

            //Console.ReadKey();
            //----------------------------------------------------------------------------------------
            //3.兩光法師時常替人占卜，由於他算得又快有便宜，因此生意源源不絕，時常大排長龍，他想算 得更快一點，因此找了你這位電腦高手幫他用電腦來加快算命的速度。
            //他的占卜規則很簡單，規則是這樣的，隨機產生一個今年日期，然後依照下面的公式：
            //M = 月 D = 日 S = (M * 2 + D) % 3
            //得到 S 的值，再依照 S 的值從 0 到 2 分別給與 普通、吉、大吉 等三種不同的運勢，輸出運勢。

            //Console.WriteLine("3.兩光法師時常替人占卜，由於他算得又快有便宜，因此生意源源不絕，時常大排長龍，他想算 得更快一點，因此找了你這位電腦高手幫他用電腦來加快算命的速度。");
            //Console.WriteLine("他的占卜規則很簡單，規則是這樣的，隨機產生一個今年日期，然後依照下面的公式：");
            //Console.WriteLine("M = 月 D = 日 S = (M * 2 + D) % 3");
            //Console.WriteLine("得到 S 的值，再依照 S 的值從 0 到 2 分別給與 普通、吉、大吉 等三種不同的運勢，輸出運勢。\n");

            //Random Rom = new Random();

            //int year = DateTime.Now.Year;
            //int month = Rom.Next(1, 13);
            //int day;
            //bool isLeapyear = DateTime.IsLeapYear(year);

            //switch (month)
            //{
            //    case 1: day = Rom.Next(1, 31 + 1); break;
            //    case 2:
            //        if (isLeapyear)
            //        {
            //            day = Rom.Next(1, 29 + 1);
            //        }
            //        else
            //        {
            //            day = Rom.Next(1, 28 + 1);
            //        }
            //        ; break;
            //    case 3: day = Rom.Next(1, 31 + 1); break;
            //    case 4: day = Rom.Next(1, 30 + 1); break;
            //    case 5: day = Rom.Next(1, 31 + 1); break;
            //    case 6: day = Rom.Next(1, 30 + 1); break;
            //    case 7: day = Rom.Next(1, 31 + 1); break;
            //    case 8: day = Rom.Next(1, 31 + 1); break;
            //    case 9: day = Rom.Next(1, 30 + 1); break;
            //    case 10: day = Rom.Next(1, 31 + 1); break;
            //    case 11: day = Rom.Next(1, 30 + 1); break;
            //    case 12: day = Rom.Next(1, 31 + 1); break;
            //    default:
            //        day = Rom.Next(1, 28 + 1);
            //        break;
            //}

            //DateTime selectedDay = new DateTime(year, month, day);

            //Console.WriteLine($"selected day: {selectedDay:yyyy年MM月dd日}"); //for check value

            //int S = (month * 2 + day) % 3;

            //Console.WriteLine("您的運勢為: ");
            //if (S == 0)
            //{
            //    Console.WriteLine("普通");
            //}
            //else if (S == 1)
            //{
            //    Console.WriteLine("吉");
            //}
            //else
            //{ // S==2
            //    Console.WriteLine("大吉");
            //}

            //Console.ReadKey();
            //----------------------------------------------------------------------------------------








        }

        public static bool IsRepeat(string element, string[] targert)
        {
            //測試element是否在target array裡
            //預設回傳false
            //逐一比對，有比對到的話回傳true
            bool IsRepeat = false;

            foreach (string item in targert)
            {

                if (item == element)
                {
                    IsRepeat = true;
                    break;
                }
            }

            return IsRepeat;
        }
    }
}
