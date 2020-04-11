using System;
using System.Collections.Generic;

namespace listexercises
{
    class Program
    {
        static void Main(string[] args)
        {
        //    List<string> planetList = new List<string>(){"Mercury", "Mars"};
        //     planetList.Add ("Jupiter");
        //      planetList.Add ("Saturn");
        //    List<string> planetListTwo = new List<string>(){"Neptune", "Pluto"};
          
        //    planetList.AddRange (planetListTwo);
        //    planetList.Insert(2,"Earth");
        //    planetList.Insert(1,"Venus");
        //    List<string> rockies = planetList.GetRange(0,4);
        //    planetList.Remove("Pluto");

         //    foreach(string pL in planetList){
        //    Console.WriteLine(pL);
        //    }
        //    foreach(string r in rockies){
        //    Console.WriteLine(r);
        //    }

//  Random random = new Random();
//  List<int> numbers = new List<int> {
//     random.Next(6),
//     random.Next(6),
//     random.Next(6),
//     random.Next(6),
//     random.Next(6),
//     random.Next(6),
// };
// for (int i=0; i<numbers.Count; i++) {
//    // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
//    if (numbers.Contains(i))
//    {
//        Console.WriteLine("there");
//    }
//    else 
//    {
//        Console.WriteLine("not there");
//    }
// }


// Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();


// wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
// wordsAndDefinitions.Add("Neat", "The dream of never waiting tables again");

//      Console.WriteLine(wordsAndDefinitions["Awesome"]);

// foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
// {
//     Console.WriteLine($" The definition of {word.Key} is {word.Value}");
// }     




// List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

// Dictionary<string, string> excitedWord = new Dictionary<string, string>();

// excitedWord.Add("word", "excited");
// excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
// excitedWord.Add("part of speech", "adjective");
// excitedWord.Add("example sentence", "I am excited to learn C#!");

// dictionaryOfWords.Add(excitedWord);

// Dictionary<string, string> newDictionary = new Dictionary<string, string>();
     
//        newDictionary.Add( "word", "super-mega-rageous");
//        newDictionary.Add( "definition", "rad");
        
// dictionaryOfWords.Add(newDictionary);

// foreach (Dictionary<string, string> word in dictionaryOfWords)
// {
    
//     foreach (KeyValuePair<string, string> wordData in word)
//     {
//         Console.WriteLine($"{wordData.Key}: {wordData.Value}");
//     }
// }

Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>>();
idioms.Add("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
idioms.Add("Injury", new List<string> { "Add", "insult", "to", "injury" });
idioms.Add("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
idioms.Add("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
idioms.Add("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
idioms.Add("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
idioms.Add("Grain", new List<string> { "Take","what","someone","says","with","a","grain","of","salt" });
idioms.Add("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
idioms.Add("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
idioms.Add("Lucifer", new List<string> { "Speak", "of", "the", "devil" });

foreach(KeyValuePair<string, List<string>> id in idioms)
{
    Console.WriteLine($"{id.Key}: {String.Join(" ",id.Value)}");
}


        }

    }
   
   
}
