using System;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("What head do you want to see?");
      string head=Console.ReadLine();
      head=head.ToLower();
      Console.WriteLine("What body do you want to see?");
      string body=Console.ReadLine();
      body=body.ToLower();
      Console.WriteLine("What feet do you want to see?");
      string feet=Console.ReadLine();
      feet=feet.ToLower();
      BuildACreature(head,body,feet);
    }
    static void BuildACreature(string head, string body, string feet){
      switch(head){
        case "bug":
          BugHead();
        break;
        case "monster":
          MonsterHead();
        break;
        case "ghost":
          GhostHead();
        break;
        default:
         Console.WriteLine("Wrong Input");
        break;
      }
      switch(body){
        case "bug":
          BugBody();
        break;
        case "monster":
          MonsterBody();
        break;
        case "ghost":
          GhostBody();
        break;
        default:
         Console.WriteLine("Wrong Input");
        break;
      }
      switch (feet){
        case "bug":
          BugFeet();
        break;
        case "monster":
          MonsterFeet();
        break;
        case "ghost":
          GhostFeet();
        break;
        default:
         Console.WriteLine("Wrong Input");
        break;
      }
    }
    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }
  }
}
