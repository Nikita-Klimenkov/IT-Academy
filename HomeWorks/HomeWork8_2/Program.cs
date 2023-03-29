using System.Reflection;
using dz8_namespace;

Type mytype = typeof(Class_dz8);

Console.WriteLine($"Name: {mytype.Name}");
Console.WriteLine($"Full Name: {mytype.FullName}");
Console.WriteLine($"Namespace: {mytype.Namespace}");
Console.WriteLine($"Is struct: {mytype.IsValueType}");
Console.WriteLine($"Is class: {mytype.IsClass}");

foreach (var member in mytype.GetMembers())
{
    Console.WriteLine($"{member.Name}, {member.MemberType}, {member.DeclaringType}");
}

Class_dz8 classDz8 = new Class_dz8();
Class_dz8 classDz82 = new Class_dz8("", 123, 757, "");

Console.WriteLine(classDz8.Email);