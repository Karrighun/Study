// По заданному номеру дня недели вывести его название
String DayName(int i)
{
if(i == 1) return "Monday";
if(i == 2) return "Tuesday";
if(i == 3) return "Wednesday";
if(i == 4) return "Thursday";
if(i == 5) return "Friday";
if(i == 6) return "Saturday";
if(i == 7) return "Sunday";
return "Некоректный номер дня недели";
}
Console.WriteLine(DayName(7));
//done