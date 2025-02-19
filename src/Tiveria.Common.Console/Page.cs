﻿using System;
using System.Linq;

namespace Tiveria.Common.XConsole
{
    public abstract class Page
    {
        public string Title { get; private set; }

        public Program Program { get; set; }

        public Page(string title, Program program)
        {
            Title = title;
            Program = program;
        }

        public virtual void Display()
        {
            if (Program.History.Count > 1 && Program.BreadcrumbHeader)
            {
                string breadcrumb = null;
                foreach (var title in Program.History.Select((page) => page.Title).Reverse())
                    breadcrumb += title + " > ";
                breadcrumb = breadcrumb.Remove(breadcrumb.Length - 3);
                System.Console.WriteLine(breadcrumb);
            }
            else
            {
                System.Console.WriteLine(Title);
            }
            System.Console.WriteLine("---");
        }
    }

}
