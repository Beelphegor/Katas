using System.Collections.Generic;
using Machine.Specifications;

namespace DevTests.CSharp.Recursion
{
    public class when_printing_a_hierarchy_list_as_a_string
    {
        static string _result;
        static string _expectedHierarchyString;
        static List<Folder> _folders = new List<Folder>();

        Establish context = () =>
                                {
                                    ConstructTree();

                                    _expectedHierarchyString =
                                        @"root
-root child 1
--root child 1's child
---root child 1's child's child
---root child 2's child's child
-root child 2
--root child 2's child";
                                };

        Because of = () => _result = _folders.ToTreeString();

        It should_return_the_expected_string = () => _result.ShouldEqual(_expectedHierarchyString);

        static void ConstructTree()
        {
            var folder6 = new Folder
                              {
                                  Id = 6,
                                  Name = "root child 2's child's child 2"
                              };
            var folder7 = new Folder
                              {
                                  Id = 7,
                                  Name = "root child 2's child's child 1"
                              };

            var folder5 = new Folder
                              {
                                  Id = 5,
                                  Name = "root child 1's child",
                                  Children = new List<Folder>
                                                 {
                                                     folder6,
                                                     folder7
                                                 },
                              };
            folder6.Parent = folder5;
            folder7.Parent = folder5;

            var folder3 = new Folder
                              {
                                  Id = 3,
                                  Name = "root child 1",
                                  Children = new List<Folder>
                                                 {
                                                     folder5
                                                 }
                              };
            folder5.Parent = folder3;

            var folder4 = new Folder
                              {
                                  Id = 4,
                                  Name = "root child 2's child"
                              };

            var folder2 = new Folder
                              {
                                  Id = 2,
                                  Name = "root child 2",
                                  Children = new List<Folder>
                                                 {
                                                     folder4
                                                 }
                              };
            folder4.Parent = folder2;

            var root = new Folder
                           {
                               Id = 1,
                               Name = "root",
                               Children = new List<Folder>
                                              {
                                                  folder3,
                                                  folder2
                                              }
                           };
            folder3.Parent = root;
            folder2.Parent = root;

            _folders = new List<Folder>();
            _folders.Add(root);
            _folders.Add(folder2);
            _folders.Add(folder3);
            _folders.Add(folder4);
            _folders.Add(folder5);
            _folders.Add(folder6);
            _folders.Add(folder7);
        }
    }
}