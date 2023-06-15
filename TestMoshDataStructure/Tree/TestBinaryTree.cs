using MoshDataStructure.Tree;

namespace TestMoshDataStructure.Tree;

public class TestBinaryTree
{
    public class BinaryTreeTests
    {
        [Fact]
        public void Constructor_LevelOrderTraversal_ShouldCreateBinaryTree()
        {
            // Arrange
            int[] levelOrder = { 5, 8, 9, 2, 1, 3, 7, 4, 6 };

            // Act
            var tree = new BinaryTree(levelOrder);

            // Assert
            Assert.NotNull(tree.Root);
            Assert.Equal(5, tree.Root.Value);
            Assert.Equal(8, tree.Root.Left.Value);
            Assert.Equal(9, tree.Root.Right.Value);
            Assert.Equal(2, tree.Root.Left.Left.Value);
            Assert.Equal(1, tree.Root.Left.Right.Value);
            Assert.Equal(3, tree.Root.Right.Left.Value);
            Assert.Equal(7, tree.Root.Right.Right.Value);
            Assert.Equal(4, tree.Root.Left.Left.Left.Value);
            Assert.Equal(6, tree.Root.Left.Left.Right.Value);
        }
        
        [Fact]
        public void Insert_ShouldInsertNodeCorrectly()
        {
            // Arrange
            var tree = new BinaryTree();

            // Act
            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);

            // Assert
            Assert.Equal(10, tree.Root.Value);
            Assert.Equal(5, tree.Root.Left.Value);
            Assert.Equal(15, tree.Root.Right.Value);
        }

        [Fact]
        public void Insert_ShouldNotThrowWhenEmpty()
        {
            // Arrange
            var tree = new BinaryTree();

            // Act
            var res = tree.Find(20);

            // Assert
            Assert.False(res);
        }

        [Fact]
        public void Find_ShouldReturnTrue_WhenValueExists()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);

            // Act
            var result = tree.Find(5);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Find_ShouldReturnFalse_WhenValueDoesNotExist()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);

            // Act
            var result = tree.Find(20);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TraverseInOrder_ShouldReturnValuesInOrder()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);
            tree.Insert(2);
            tree.Insert(8);

            // Act
            var result = tree.TraverseInOrder();

            // Assert
            Assert.Equal("2,5,8,10,15", result);
        }

        [Fact]
        public void TraversePreOrder_ShouldReturnValuesInPreOrder()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);
            tree.Insert(2);
            tree.Insert(8);

            // Act
            var result = tree.TraversePreOrder();

            // Assert
            Assert.Equal("10,5,2,8,15", result);
        }

        [Fact]
        public void TraversePostOrder_ShouldReturnValuesInPostOrder()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);
            tree.Insert(2);
            tree.Insert(8);

            // Act
            var result = tree.TraversePostOrder();

            // Assert
            Assert.Equal("2,8,5,15,10", result);
        }

        [Fact]
        public void Find_ShouldReturnFalse_WhenTreeIsEmpty()
        {
            // Arrange
            var tree = new BinaryTree();

            // Act
            var result = tree.Find(10);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TraverseInOrder_ShouldReturnEmptyString_WhenTreeIsEmpty()
        {
            // Arrange
            var tree = new BinaryTree();

            // Act
            var result = tree.TraverseInOrder();

            // Assert
            Assert.Equal("", result);
        }

        [Fact]
        public void TraversePreOrder_ShouldReturnEmptyString_WhenTreeIsEmpty()
        {
            // Arrange
            var tree = new BinaryTree();

            // Act
            var result = tree.TraversePreOrder();

            // Assert
            Assert.Equal("", result);
        }

        [Fact]
        public void TraversePostOrder_ShouldReturnEmptyString_WhenTreeIsEmpty()
        {
            // Arrange
            var tree = new BinaryTree();

            // Act
            var result = tree.TraversePostOrder();

            // Assert
            Assert.Equal("", result);
        }

        [Fact]
        public void Height_ShouldReturnNegetiveOne_WhenTreeIsEmpty()
        {
            // Arrange
            var tree = new BinaryTree();

            // Act
            var result = tree.Height;

            // Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Height_ShouldReturnCorrectHeight_WhenTreeHasMultipleLevels()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);
            tree.Insert(2);
            tree.Insert(8);
            tree.Insert(12);
            tree.Insert(20);

            // Act
            var result = tree.Height;

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Height_ShouldReturnZero_WhenTreeHasOnlyOneLevel()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);

            // Act
            var result = tree.Height;

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Height_ShouldReturnZero_WhenTreeHasOnlyTwoLevels()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);
            tree.Insert(2);
            tree.Insert(8);

            // Act
            var result = tree.Height;

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Height_ShouldReturnZero_WhenTreeHasOnlyThreeLevels()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);
            tree.Insert(2);
            tree.Insert(8);
            tree.Insert(12);
            tree.Insert(20);

            // Act
            var result = tree.Height;

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Min_ShouldReturnMinValue_WhenTreeHasOnlyRootNode()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Insert(10);

            // Act
            var result = tree.Min;

            // Assert
            Assert.Equal(10, result);
        }

        [Fact]
        public void Min_ShouldReturnMinValue_WhenTreeHasFewNodes()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Insert(12);
            tree.Insert(10);

            // Act
            var result = tree.Min;

            // Assert
            Assert.Equal(10, result);
        }

        [Fact]
        public void Min_ShouldReturnMinValue_WhenTreeHasMultipleNodes()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);
            tree.Insert(2);
            tree.Insert(8);
            tree.Insert(12);
            tree.Insert(20);

            // Act
            var result = tree.Min;

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Min_ShouldThrowExcepction_WhenTreeIsEmpty()
        {
            // Arrange
            var tree = new BinaryTree();

            // Assert
            Assert.Throws<InvalidOperationException>(() => tree.Min);
        }

        [Fact]
        public void Equals_ShouldReturnTrue_WhenTreesAreEqual()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);
            tree.Insert(2);
            tree.Insert(8);
            tree.Insert(12);
            tree.Insert(20);

            var tree2 = new BinaryTree();
            tree2.Insert(10);
            tree2.Insert(5);
            tree2.Insert(15);
            tree2.Insert(2);
            tree2.Insert(8);
            tree2.Insert(12);
            tree2.Insert(20);

            // Act
            var result = tree.Equals(tree2);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Equals_ShouldReturnTrue_WhenTwoTreesAreEqual()
        {
            // Arrange
            var tree1 = new BinaryTree();
            tree1.Insert(10);
            tree1.Insert(5);
            tree1.Insert(15);

            var tree2 = new BinaryTree();
            tree2.Insert(10);
            tree2.Insert(5);
            tree2.Insert(15);

            // Act
            var result = tree1.Equals(tree2);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Equals_ShouldReturnFalse_WhenTwoTreesAreNotEqual()
        {
            // Arrange
            var tree1 = new BinaryTree();
            tree1.Insert(10);
            tree1.Insert(5);
            tree1.Insert(15);

            var tree2 = new BinaryTree();
            tree2.Insert(10);
            tree2.Insert(7);
            tree2.Insert(15);

            // Act
            var result = tree1.Equals(tree2);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Equals_ShouldReturnFalse_WhenOneTreeIsNull()
        {
            // Arrange
            var tree1 = new BinaryTree();
            tree1.Insert(10);
            tree1.Insert(5);
            tree1.Insert(15);

            BinaryTree tree2 = null;

            // Act
            var result = tree1.Equals(tree2);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ValidateBST_ShouldReturnTrue_WhenTreeIsBST()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);
            tree.Insert(3);
            tree.Insert(8);

            // Act
            var result = tree.ValidateBst();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ValidateBST_ShouldReturnFalse_WhenTreeIsNotBST()
        {
            // Arrange
            var tree = new BinaryTree
            {
                Root = new BinaryTree.Node(10)
                {
                    Left = new BinaryTree.Node(15),
                    Right = new BinaryTree.Node(5)
                }
            };

            // Act
            var result = tree.ValidateBst();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ValidateBST_ShouldReturnTrue_WhenTreeIsEmpty()
        {
            // Arrange
            var tree = new BinaryTree();

            // Act
            var result = tree.ValidateBst();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ValidateBST_ShouldReturnTrue_WhenTreeHasSingleNode()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Insert(10);

            // Act
            var result = tree.ValidateBst();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void GetNodesAtDistance_ShouldReturnNodesAtDistance_WhenDistanceIsGreaterThanZero()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);
            tree.Insert(3);
            tree.Insert(8);

            // Act
            var result = tree.GetNodesAtDistance(2);

            // Assert
            Assert.Equal(new List<int> {3, 8}, result);
        }

        [Fact]
        public void GetNodesAtDistance_ShouldReturnFirstElement_WhenDistanceIsZero()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);
            tree.Insert(3);
            tree.Insert(8);

            // Act
            var result = tree.GetNodesAtDistance(0);

            // Assert
            Assert.Equal(new List<int> {10}, result);
        }

        [Fact]
        public void GetNodesAtDistance_ShouldReturnEmptyList_WhenDistanceIsNegative()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);
            tree.Insert(3);
            tree.Insert(8);

            // Act
            var result = tree.GetNodesAtDistance(-1);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void GetNodesAtDistance_ShouldReturnNodesAtDistance_WhenTreeHaveLeftSide()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Insert(10);
            tree.Insert(5);

            // Act
            var result = tree.GetNodesAtDistance(1);

            // Assert
            Assert.Equal(new List<int> {5}, result);
        }

        [Fact]
        public void GetNodesAtDistance_ShouldReturnNodesAtDistance_WhenTreeHaveRightSide()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Insert(10);
            tree.Insert(15);

            // Act
            var result = tree.GetNodesAtDistance(1);

            // Assert
            Assert.Equal(new List<int> {15}, result);
        }

        [Fact]
        public void GetNodesAtDistance_ShouldReturnNodesAtDistance_WhenTreeHaveRightSide2()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Insert(10);
            tree.Insert(15);
            tree.Insert(5);
            tree.Insert(25);

            // Act
            var result = tree.GetNodesAtDistance(2);

            // Assert
            Assert.Equal(new List<int> {25}, result);
        }

        [Fact]
        public void GetNodesAtDistance_ShouldReturnEmptyList_WhenTreeIsEmpty()
        {
            // Arrange
            var tree = new BinaryTree();

            // Act
            var result = tree.GetNodesAtDistance(2);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void GetNodesAtDistance_ShouldReturnNodesAtDistance_WhenTreeHasMultipleChildren()
        {
            // Arrange
            var tree = new BinaryTree();

            tree.Insert(8);

            tree.Insert(5);

            tree.Insert(3);
            tree.Insert(7);

            tree.Insert(6);
            tree.Insert(4);

            tree.Insert(2);
            tree.Insert(1);

            // right
            tree.Insert(14);

            tree.Insert(12);
            tree.Insert(15);

            tree.Insert(11);
            tree.Insert(13);

            tree.Insert(10);
            tree.Insert(9);


            // Act
            var result = tree.GetNodesAtDistance(3);

            // Assert
            Assert.Equal(new List<int> {2, 4, 6, 11, 13}, result);
        }

        [Fact]
        public void TraverseLevelOrder_ShouldReturnLevels_WhenTreeHasMultipleLevels()
        {
            // Arrange
            var tree = new BinaryTree();

            tree.Insert(8);

            tree.Insert(5);

            tree.Insert(3);
            tree.Insert(7);

            tree.Insert(6);
            tree.Insert(4);

            tree.Insert(2);
            tree.Insert(1);

            // right
            tree.Insert(14);

            tree.Insert(12);
            tree.Insert(15);

            tree.Insert(11);
            tree.Insert(13);

            tree.Insert(10);
            tree.Insert(9);

            // Act
            var result = tree.TraverseLevelOrder();

            // Assert
            var expected = new Dictionary<int, List<int>>
            {
                {0, new List<int> {8}},
                {1, new List<int> {5, 14}},
                {2, new List<int> {3, 7, 12, 15}},
                {3, new List<int> {2, 4, 6, 11, 13}},
                {4, new List<int> {1, 10}},
                {5, new List<int> {9}}
            };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TraverseLevelOrder_ShouldReturnEmptyDictionary_WhenTreeIsEmpty()
        {
            // Arrange
            var tree = new BinaryTree();

            // Act
            var result = tree.TraverseLevelOrder();

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void TraverseLevelOrder_ShouldReturnSingleLevel_WhenTreeHasOnlyRootNode()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Insert(10);

            // Act
            var result = tree.TraverseLevelOrder();

            // Assert
            var expected = new Dictionary<int, List<int>>
            {
                {0, new List<int> {10}}
            };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TraverseLevelOrder_ShouldReturnLevelsInCorrectOrder_WhenTreeHasSkewedStructure()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Insert(1);
            tree.Insert(2);
            tree.Insert(3);
            tree.Insert(4);
            tree.Insert(5);

            // Act
            var result = tree.TraverseLevelOrder();

            // Assert
            var expected = new Dictionary<int, List<int>>
            {
                {0, new List<int> {1}},
                {1, new List<int> {2}},
                {2, new List<int> {3}},
                {3, new List<int> {4}},
                {4, new List<int> {5}}
            };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void MaxSumOfLevels_ShouldReturnCorrectOnTree()
        {
            // Arrange
            var tree = new BinaryTree
            {
                Root = new BinaryTree.Node(1)
                {
                    Left = new BinaryTree.Node(1),
                    Right = new BinaryTree.Node(0)
                }
            };

            tree.Root.Left.Left = new BinaryTree.Node(7);
            tree.Root.Left.Right = new BinaryTree.Node(-8);
            tree.Root.Right.Left = new BinaryTree.Node(-7);
            tree.Root.Right.Right = new BinaryTree.Node(-9);


            // Act
            var level = tree.MaxSumOfLevels();

            // Assert
            Assert.Equal(1, level);
        }        
    }
}