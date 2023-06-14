using MoshDataStructure.Hashmap;

namespace TestMoshDataStructure.Hashmap;

public class TestHashtable
{
    [Fact]
    public void Put_AddsKeyValuePairToHashTable()
    {
        // Arrange
        var hashTable = new HashTable();

        // Act
        hashTable.Put(1, "Value 1");
        hashTable.Put(2, "Value 2");
        hashTable.Put(6, "Value 6");

        // Assert
        Assert.True(hashTable.Contains(1));
        Assert.True(hashTable.Contains(2));
        Assert.True(hashTable.Contains(6));
    }

    [Fact]
    public void Put_ReplaceValueForDuplicateKey()
    {
        // Arrange
        var hashTable = new HashTable();
        hashTable.Put(1, "Value 1");
        hashTable.Put(1, "Value 2");

        Assert.Equal("Value 2", hashTable.Get(1));
    }

    [Fact]
    public void Get_ReturnsValueForKey()
    {
        // Arrange
        var hashTable = new HashTable();
        hashTable.Put(1, "Value 1");
        hashTable.Put(2, "Value 2");

        // Act
        var value1 = hashTable.Get(1);
        var value2 = hashTable.Get(2);

        // Assert
        Assert.Equal("Value 1", value1);
        Assert.Equal("Value 2", value2);
    }

    [Fact]
    public void Get_ReturnsNullForNonexistentKey()
    {
        // Arrange
        var hashTable = new HashTable();
        hashTable.Put(1, "Value 1");

        // Act
        var value = hashTable.Get(2);

        // Assert
        Assert.Null(value);
    }

    [Fact]
    public void Remove_RemovesKeyValuePairFromHashTable()
    {
        // Arrange
        var hashTable = new HashTable();
        hashTable.Put(1, "Value 1");
        hashTable.Put(2, "Value 2");

        // Act
        hashTable.Remove(1);

        // Assert
        Assert.False(hashTable.Contains(1));
    }

    [Fact]
    public void Contains_ReturnsTrueForExistingKey()
    {
        // Arrange
        var hashTable = new HashTable();
        hashTable.Put(1, "Value 1");

        // Act
        var containsKey = hashTable.Contains(1);

        // Assert
        Assert.True(containsKey);
    }

    [Fact]
    public void Contains_ReturnsFalseForNonexistentKey()
    {
        // Arrange
        var hashTable = new HashTable();
        hashTable.Put(1, "Value 1");

        // Act
        var containsKey = hashTable.Contains(2);

        // Assert
        Assert.False(containsKey);
    }
}