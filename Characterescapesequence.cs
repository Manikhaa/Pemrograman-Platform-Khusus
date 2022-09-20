Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");

//escape sequence
Console.WriteLine("Hello \"World\"");
Console.WriteLine("\n c:\\source\\repost \n");

//step 1
Console.WriteLine("Generating invoices for customer \"ABC Corp\"...\n");
Console.WriteLine("Invoices:\t1021 \tComplete!");
Console.WriteLine("Invoices:\t1022 \tComplete!");
Console.WriteLine("\nOutput Directory:");
Console.WriteLine(@"c:\invoices");
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");

Console.WriteLine("\n");
//verbatim string
Console.WriteLine(@"c:\source\repost(""this is where your code goes"")");

//
