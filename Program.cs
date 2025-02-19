// Chandler Wixom, 2/19/2025, Lab 4 Madlibs

using System.Runtime.CompilerServices;

Console.WriteLine("This is the game Mad Libs, you will be requested to provide differnt types of words\nThese words will then be combined in a pre-existing sentance to make a funny story\nEnter the requested word types:");

string originalStory = "A vacation is when you take a trip to some (adjective) place with your (adjective) family. Usually, you go to some place that is near a/an (noun) or up on a/an (noun). A good vacation place is one where you can ride (plural noun) or play (game) or go hunting for (plural noun). I like to spend my time (verb ending in “ing”) or (verb ending in “ing”). When parents go on a vacation, they spend their time eating three (plural noun) a day, and fathers play golf, and mothers sit around (verb ending in “ing”) Last summer, my little brother fell in a/an (noun) and got poison (plant) all over his (part of the body) My family is going to go to (place) and I will practice (verb ending in “ing”) Parents need vacations more than kids because parents are always very (adjective) and because they have to work (number) hours every day all year making enough (plural noun) to pay for the vacation.";
string[] storyWords = originalStory.Split(' ');
string finalStory = "";



for (int i = 0; i < storyWords.Length; i++)
{

    if (storyWords[i].Substring(0, 1) == "(" && storyWords[i].Contains(")")) // if it starts with ( and ends in ) its is saved
    {
        Console.WriteLine($"Please provide a {storyWords[i].Replace('.', ' ')}");
        finalStory = finalStory + Console.ReadLine();
        if (storyWords[i].EndsWith('.'))
            finalStory = finalStory + ". ";
        else
            finalStory = finalStory + " ";
    }
    else if (storyWords[i].Substring(0, 1) == "(" && !storyWords[i].Contains(")")) // if its starts with ( but doesnt end in ) it keeps adding till it finds something that ends in )
    {
        string tempQuest = "";
        while (!storyWords[i].Contains(")"))
        {
            // Console.Write(storyWords[i] + " ");
            tempQuest = tempQuest + storyWords[i] + " ";
            i++;
        }
        tempQuest = tempQuest + storyWords[i];
        Console.WriteLine($"Please provide a {tempQuest.Replace('.', ' ')}");
        finalStory = finalStory + Console.ReadLine();
        if (storyWords[i].EndsWith('.'))
            finalStory = finalStory + ". ";
        else
            finalStory = finalStory + " ";

    }
    else // otherwise its added to the story directly
    {
        finalStory = finalStory + storyWords[i] + " ";
    }

}
Console.WriteLine(finalStory);

