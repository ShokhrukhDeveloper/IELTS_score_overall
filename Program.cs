// Console.WriteLine("IELTS score FOR academic ");

// Console.Write("Listening score: ");
// string listeningScoreInput = Console.ReadLine()!;

// Console.Write("Reading score: ");
// string readingScoreInput = Console.ReadLine()!;

// Console.Write("Speaking score: ");
// string speakingScoreInput = Console.ReadLine()!;

// Console.Write("Writing score: ");
// string writingScoreInput = Console.ReadLine()!;

// decimal[] scores={
//     Convert.ToDecimal(readingScoreInput),
//     Convert.ToDecimal(listeningScoreInput),
//     Convert.ToDecimal(writingScoreInput),
//     Convert.ToDecimal(speakingScoreInput)
//     };

// decimal averageScore = scores.Average();
// decimal remainder = averageScore-(int)averageScore;

// remainder = remainder switch
// {
//     <   0.25m => 0m,
//     <   0.75m => 0.5m,
//     _         => 1m
// };

// averageScore=(int)averageScore+remainder;
// string scoreCategory= averageScore switch 
// {
//   9 or 8.5m => "Expert",
//   8 or 7.5m => "Very Good",
//   7 or 6.5m => "Good",
//   6 or 5.5m => "Competent",
//   5 => "Modest",
//   _ => "Invalid" 
// };

// Console.WriteLine("------------------------------------------------------------");
// Console.WriteLine($"Avreage score: {averageScore}");
// Console.WriteLine($"Candidat is {scoreCategory}");



using System.Collections;

string s="LVIII";
        Queue<int> numbers= new Queue<int>();
         int summ =0;
        foreach(char c in s)
        {
        int x= c switch
                {
                    'I'=>1,
                    'V'=>5,
                    'X'=>10,
                    'L'=>50,
                    'C'=>100,
                    'D'=>500,
                    'M'=>1000,
                    _=>0
                };
            numbers.Enqueue(x);
            
        }
       
        for (int i = 0; i < numbers.Count; i++)
        {
            
        }
