using System;
using System.Linq;
using System.Collections; // contains the IEnumerable interface
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using CSharp_Exercises.Models;


namespace CSharp_Exercises.Concepts
{
    /* Language INtegrated Query
    LINQ is a set of language extensions that add the ability to work with sequences of data
    and then filter, sort, and project them into different outputs. Instead of needing to explicitly
    state each individual action, like move, read, update, and so on, LINQ enables you to use a
    declarative aka functional style of writing statements.

    LINQ has several parts:
    -Extension methods (required): include examples such as Where, OrderBy, and Select.
    -LINQ providers (required): These include LINQ to Objects for processing in-memory objects,
    LINQ to Entities for processing data stored in external databases and modeled with EF Core,
    and LINQ to XML for processing data stores as XML. These providers are the part of LINQ that
    executes LINQ expressions in a specific way to different types of data.
    -Lambda expressions (optional): these can be used instead of named methods to simplify LINQ
    queries. I.E. for the conditional logic of the Where method for filtering.
    -LINQ query comprehension syntax (optional): These include C# keywords like from, in, where,
    orderby, descending, and select. These are aliases for some of the LINQ extension methods, and
    their use can simplify the queries you write, especially if you already have experience with
    other query languages, such as Structured Query Language (SQL).
    
    The LINQ extension methods are appended by the Enumerable static class to any type, known as
    a sequence, that implements IEnumerable<T>. For example, an array of any type implements the
    IEnumerable<T> class, where T is the type of item in the array. This means that all arrays 
    support LINQ to query and manipulate them. All generic collections implement IEnumerable<T>. so
    they can be queried and manipulated with LINQ too.
    */
    internal class Linq
    {
        //private SqlConnection connection;
        SQL_DBContext context;

        public Linq()
        {
            // Get SQL connection string and create connection
            //GrabLocalDatabaseCredentials credentialGrabber = new GrabLocalDatabaseCredentials();
            //connection = new SqlConnection(credentialGrabber.sqlConnStr);
            context = new SQL_DBContext();
        }

        public void ExtensionMethods()
        {
            string[] list = [ "css", "gif", "htm", "html", "txt", "xml" ];
            //string[] list = new string[1];
            /* First, FirstOrDefault, Last, LastOrDefault
            Get the first or last item in the sequence or throw an exception, or return the default
            value for the type, for example, 0 for an int and null for a reference type, if there
            is not a first or last item. */
            string? test = list.FirstOrDefault();

            /* Where
            Returns a sequence of items that match a specified filter. */
            /* Single, SingleOrDefault
            Returns an item that matches a specific filter or throw an exception, or return the default
            value for the type if there is not exactly one match. */
            test = list.Where(x => x == "css").SingleOrDefault();

            /* ElementAt, ElementAtOrDefault
            Returns an item at a specified index position or throws an exception, or returns the default
            value for the type if there is not an item at that position. */
            test = list.ElementAtOrDefault(2);

            /* Select, SelectMany
            Project items into a different shape, that is, a different type, and flatten a nester
            hierarchy of items. */
            test = list.Select(x => x = "html").ToString();

            /* OrderBy, OrderByDescending, ThenBy, ThenByDescending
            Sort items by a specified field or property. */
            List<Employee> employees = context.Employees.ToList();
            List<Employee> subList = employees.OrderByDescending(employee => employee.Id).ToList();

            /* Order, OrderDescending
            Sort items by the item itself */
            subList = employees.OrderBy(employee => employee.Name).ToList();

            /* Reverse
            Reverse the order of the items */
            subList.Reverse();// = employees.Reverse().ToList();

            /* GroupBy, GroupJoin, Join
            
            */
            Console.WriteLine();

            /*
            
            */
            /*
            
            */
            /*
            
            */
            /*
            
            */
            Console.WriteLine();
            Console.WriteLine(test);
        }

    }
}
