using System;

class Program
{
    static void Main(string[] args)
    {
        // ==========================================
        // SECTION 1: CARD & DECK TESTING
        // ==========================================
        Console.WriteLine("=== Card/Deck Tester ===");

        // 1. Initialize Deck
        Deck deck = new Deck();
        // Verifying the deck contains exactly 52 cards
        Console.WriteLine($"Step 1: Deck Initialized. Card count: {deck.Cards.Count}");

        // 2. Test TakeTopCard (Before Shuffle)
        // Using Card? to prevent null reference warnings
        Card? firstCard = deck.TakeTopCard();
        Console.WriteLine($"Step 2: Taking top card: {firstCard}"); 

        // 3. Test Shuffle
        Console.WriteLine("\nStep 3: Shuffling the deck...");
        deck.Shuffle(); 
        
        Card? shuffledCard = deck.TakeTopCard();
        Console.WriteLine($"Taking new top card after shuffle: {shuffledCard}");

        // 4. Test Cut
        Console.WriteLine("\nStep 4: Cutting the deck at index 10...");
        deck.Cut(10); 
        Card? cutCard = deck.TakeTopCard();
        Console.WriteLine($"Taking top card after cut: {cutCard}");

        // 5. Test Null Safety
        Console.WriteLine("\nStep 5: Emptying deck to test null safety...");
        int remainingCards = deck.Cards.Count;
        for (int i = 0; i < remainingCards; i++)
        {
            deck.TakeTopCard();
        }

        Card? emptyCard = deck.TakeTopCard();
        if (emptyCard == null)
        {
            Console.WriteLine("Success: TakeTopCard returned null safely for empty deck.");
        }

        Console.WriteLine("\n--- Card Testing Complete ---\n");

        // ==========================================
        // SECTION 2: BANK ACCOUNT TESTING
        // ==========================================
        Console.WriteLine("=== Bank Account Tester ===");
        
        // Initializing account with initial balance
        BankAccount myAcc = new BankAccount("JoyBoy", 1000m);
        Console.WriteLine($"Account ID: {myAcc.AccountID} | Owner: {myAcc.CustomerName}");
        
        // Testing successful deposit and withdrawal
        myAcc.Deposit(500m);
        myAcc.Withdraw(200m);
        
        // Testing failure case: Overdraft
        bool failedWithdraw = myAcc.Withdraw(5000m);
        Console.WriteLine($"Overdraft Attempt (Expected Fail): {!failedWithdraw}");
        Console.WriteLine($"Current Balance: {myAcc.Balance:C}");

        // Displaying transaction history as required
        Console.WriteLine("\nTransaction History:");
        foreach (var t in myAcc.Transactions) 
        {
            Console.WriteLine(t);
        }

        Console.WriteLine("\n--- All Testing Complete ---");
        Console.ReadLine();
    }
}