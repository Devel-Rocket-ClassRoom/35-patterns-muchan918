using System;

int[] scores = { 95, 87, 73, 65, 45, 30 };

Console.WriteLine("=== 성적 평가기 ===");
foreach(var score in scores)
{
    Console.WriteLine($"{score}점: {GetGrade(score)} ({GetStatus(score)}) - {IsPassingGrade(score)}");
}

string GetGrade(int score) => score switch
{
    >= 90 => "A",
    >= 80 => "B",
    >= 70 => "C",
    >= 60 => "D",
    _ => "F"
};

string GetStatus(int score) => score switch
{
    >= 95 => "최우수",
    >= 90 => "우수",
    >= 70 => "보통",
    >= 40 => "노력 필요",
    _ => "재수강 권장"
};

string IsPassingGrade(int score) => score switch
{
    >= 60 => "합격",
    _ => "불합격"
};