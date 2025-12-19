using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine(" Card/Deck Tester \n");

//         // 1. Initialize Deck
//         Deck deck = new Deck();
//         Console.WriteLine($"Step 1: Deck Initialized. Card count: {deck.Cards.Count}");
//         // Should be 52

//         // 2. Test TakeTopCard (Before Shuffle)
//         Card? firstCard = deck.TakeTopCard();
//         Console.WriteLine($"Step 2: Taking top card: {firstCard}"); 
//         // Likely 'Ace of Spades' if not shuffled yet

//         // 3. Test Shuffle
//         Console.WriteLine("\nStep 3: Shuffling the deck...");
//         deck.Shuffle(); //
        
//         Card? shuffledCard = deck.TakeTopCard();
//         Console.WriteLine($"Taking new top card after shuffle: {shuffledCard}");

//         // 4. Test Cut
//         Console.WriteLine("\nStep 4: Cutting the deck at index 10...");
//         deck.Cut(10); //
//         Card? cutCard = deck.TakeTopCard();
//         Console.WriteLine($"Taking top card after cut: {cutCard}");

//         // 5. Test Null Safety (The CS8603 fix)
//         Console.WriteLine("\nStep 5: Emptying deck to test null safety...");
//         int cardsLeft = deck.Cards.Count;
//         for (int i = 0; i < cardsLeft; i++)
//         {
//             deck.TakeTopCard();
//         }

//         Card? emptyCard = deck.TakeTopCard();
//         if (emptyCard == null)
//         {
//             Console.WriteLine("Success: TakeTopCard returned null safely for empty deck.");
//         }

//         Console.WriteLine("\n--- Testing Complete ---");
//         Console.ReadLine();
//     }
// }

class Program
{
    static void Main()
    {
        BankAccount myAcc = new BankAccount("JoyBoy", 1000m);
        
        Console.WriteLine($"Account ID: {myAcc.AccountID} | Owner: {myAcc.CustomerName}");
        
        // Test Success
        myAcc.Deposit(500m);
        myAcc.Withdraw(200m);
        
        // Test Failure (Overdraft)
        bool failedWithdraw = myAcc.Withdraw(5000m);
        Console.WriteLine($"Overdraft Failed: {!failedWithdraw}");

        // Print History
        Console.WriteLine("\nTransaction History:");
        foreach (var t in myAcc.Transactions) Console.WriteLine(t);
    }
}