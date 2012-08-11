using System.Collections.Generic;
using Machine.Specifications;

namespace DevTests.CSharp.Recursion
{
    public class when_printing_an_unordered_hierarchy_as_a_pre_order_string
    {
        static Folder _root;
        static string _result;
        static string _expectedHierarchyString;

        Establish context = () =>
            {
                _root = new Folder
                            {
                                Name = "root",
                                Children = new List<Folder>
                                                {
                                                    new Folder
                                                        {
                                                            Name = "root child 1",
                                                            Children = new List<Folder>
                                                                            {
                                                                                new Folder
                                                                                    {
                                                                                        Name = "root child 2's child",
                                                                                        Children =
                                                                                            new List
                                                                                            <Folder>
                                                                                                {
                                                                                                    new Folder
                                                                                                        {
                                                                                                            Name = "root child 2's child's child"
                                                                                                        },
                                                                                                    new Folder
                                                                                                        {
                                                                                                            Name = "root child 1's child's child"
                                                                                                        }
                                                                                                },
                                                                                    }
                                                                            }
                                                        },
                                                    new Folder
                                                        {
                                                            Name = "root child 2",
                                                            Children = new List<Folder>
                                                                            {
                                                                                new Folder
                                                                                    {
                                                                                        Name = "root child 1's child"
                                                                                    }
                                                                            }
                                                        }
                                                }
                            };

                                    _expectedHierarchyString =
                                        @"root
-root child 1
--root child 1's child
---root child 1's child's child
---root child 2's child's child
-root child 2
--root child 2's child";
                                };

        Because of = () => _result = _root.ToString();

        It should_return_the_expected_string = () => _result.ShouldEqual(_expectedHierarchyString);
    }
}