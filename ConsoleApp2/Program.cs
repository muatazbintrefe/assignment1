double BILL;
Console.Write("Enter the bill amount:");
BILL = Convert.ToDouble(Console.ReadLine());
if (BILL >= 500) {Console.WriteLine($"this is you bill: {BILL = BILL * 0.80} after the disscount %20");}
else if (BILL >= 300 && BILL <=499){Console.WriteLine($"this is you bill :{BILL = BILL * 0.90} after the disscount %10");}
else{Console.WriteLine($"this is you bill :{BILL}");}