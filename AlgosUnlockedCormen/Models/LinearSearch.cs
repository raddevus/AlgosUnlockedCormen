
public class LinearSearch{

public int findMatch(string title)                
{
  // return the index if the item is found
  // return -1 if it is not found
   for (int i = 0; i < bookTitles.Length; i++) 
   { 
       if (bookTitles[i].ToLower() == title.ToLower()) 
       { 
           return i; 
       } 

   } 
   return -1; 
}

public int findMatchSentinel(string title){

   int i = 0;
   // saving value of lastIndex for ease of use
   int lastIndex = bookTitles.Length -1;
   Console.WriteLine($"There are {bookTitles.Length} titles & lastIndex is {lastIndex}");
   // save last bookTitle into last var
   var last = bookTitles[lastIndex];
   bookTitles[lastIndex] = title;
   while (bookTitles[i].ToLower() != title.ToLower()){ ++i; }
   bookTitles[lastIndex] = last;
   if (i < lastIndex || bookTitles[i].ToLower() == title.ToLower()){
      return i;
   }
   return -1;
}
    string[] bookTitles = new string[]
   {
       // Frank L. Baum - Oz series
       "The Wonderful Wizard of Oz",
       "The Marvelous Land of Oz",
       "Ozma of Oz",
       "Dorothy and the Wizard in Oz",
       "The Road to Oz",
       "The Emerald City of Oz",
       "The Patchwork Girl of Oz",
       "Tik-Tok of Oz",
       "The Scarecrow of Oz",
       "Rinkitink in Oz",
       "The Lost Princess of Oz",
       "The Tin Woodman of Oz",
       "The Magic of Oz",
       "Glinda of Oz",

       // Jane Austen
       "Pride and Prejudice",
       "Sense and Sensibility",
       "Emma",
       "Mansfield Park",
       "Northanger Abbey",
       "Persuasion",

       // Charles Dickens
       "A Tale of Two Cities",
       "Great Expectations",
       "Oliver Twist",
       "David Copperfield",
       "Bleak House",
       "Nicholas Nickleby",
       "The Pickwick Papers",
       "Hard Times",
       "Little Dorrit",

       // Mark Twain
       "The Adventures of Tom Sawyer",
       "Adventures of Huckleberry Finn",
       "A Connecticut Yankee in King Arthur’s Court",
       "The Prince and the Pauper",
       "Life on the Mississippi",
       "The Innocents Abroad",
       "Roughing It",

       // Herman Melville
       "Moby-Dick",
       "Typee",
       "Omoo",
       "White-Jacket",
       "Billy Budd, Sailor",

       // Mary Shelley
       "Frankenstein",
       "The Last Man",
       "Mathilda",

       // Bram Stoker
       "Dracula",
       "The Jewel of Seven Stars",
       "The Lair of the White Worm",

       // Robert Louis Stevenson
       "Treasure Island",
       "Strange Case of Dr Jekyll and Mr Hyde",
       "Kidnapped",
       "The Black Arrow",
       "Catriona",

       // Lewis Carroll
       "Alice’s Adventures in Wonderland",
       "Through the Looking-Glass",
       "Sylvie and Bruno",
       "Sylvie and Bruno Concluded",

       // Oscar Wilde
       "The Picture of Dorian Gray",
       "The Importance of Being Earnest",
       "Lady Windermere’s Fan",
       "Salome",

       // Edgar Allan Poe
       "The Fall of the House of Usher",
       "The Tell-Tale Heart",
       "The Raven",
       "The Murders in the Rue Morgue",
       "The Pit and the Pendulum",

       // Shakespeare
       "Hamlet",
       "Macbeth",
       "Othello",
       "King Lear",
       "Romeo and Juliet",
       "A Midsummer Night’s Dream",
       "The Tempest",
       "Twelfth Night",
       "Julius Caesar",
       "Much Ado About Nothing",

       // Homer
       "The Iliad",
       "The Odyssey",

       // Dante
       "The Divine Comedy",
       "Inferno",
       "Purgatorio",
       "Paradiso",

       // Other classics
       "Don Quixote",
       "Gulliver’s Travels",
       "The Count of Monte Cristo",
       "The Three Musketeers",
       "Les Misérables",
       "War and Peace",
       "Anna Karenina",
       "Crime and Punishment",
       "The Brothers Karamazov",
       "Madame Bovary",
       "Faust",
       "Candide",
       "The Metamorphosis",
       "The Time Machine",
       "The War of the Worlds",
       "Journey to the Center of the Earth",
       "Twenty Thousand Leagues Under the Seas"};
}       
