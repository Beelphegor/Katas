using System.Collections.Generic;
using Machine.Specifications;

namespace DevTests.CSharp.Recursion
{
    public class when_printing_club_hierarchy_as_a_string
    {
        static Folder _root;
        static string _result;
        static string _expectedHierarchyString;

        Establish context = () =>
            {
                _root = new Folder
                    {
                        Name = "President",
                        Children = new List<Folder>
                            {
                                new Folder
                                    {
                                        Name = "Vice-President"
                                    },
                                new Folder
                                    {
                                        Name = "Treasurer",
                                    },
                                new Folder
                                    {
                                        Name = "Secretary",
                                        Children = new List<Folder>
                                            {
                                                new Folder
                                                    {
                                                        Name = "Clerk"
                                                    },
                                                new Folder
                                                    {
                                                        Name = "Janitor",
                                                    }
                                            }
                                    }
                            }
                    };

                _expectedHierarchyString =
                    @"President
-Vice-President
-Treasurer
-Secretary
--Clerk
--Janitor";
            };

        Because of = () => _result = _root.ToString();

        It should_return_the_expected_string = () => _result.ShouldEqual(_expectedHierarchyString);
    }
}