// From C# 12, you can use square brackets when initializing a array.
// This is called a collection expression:

using System.Collections.Immutable;

int[] array = [1, 2, 3];

// Collection expressions also work with other collection types:

List<int> list = [1, 2, 3];

Span<int> span = [1, 2, 3];

HashSet<int> set = [1, 2, 3];

ImmutableArray<int> immutable = [1, 2, 3];

// Unfortunately, collection expressions don't have a natural type, so the following is illegal:
// var foo = [1, 2, 3];