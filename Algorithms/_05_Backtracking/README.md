# Backtracking Algorithms

## Introduction
Backtracking is a systematic algorithmic technique for solving problems recursively by building candidates incrementally and abandoning ("backtracking") a candidate as soon as it is determined to be invalid. It is particularly useful for combinatorial problems, constraint satisfaction problems, and puzzles where a complete search is required to find all possible solutions.

This approach uses a **depth-first search** (DFS) strategy and typically involves:
- **Recursion** to explore decision trees.
- **Pruning** invalid paths early to reduce computation.
- **State management** to track partial solutions.

## How Backtracking Works
1. **Choose**: Select the next candidate to build a partial solution.
2. **Explore**: Recursively attempt to extend the partial solution.
3. **Unchoose**: If the current path leads to a dead end, backtrack by undoing the last choice and try alternatives.

![Backtracking Flow](https://www.geeksforgeeks.org/wp-content/uploads/backtracking-algorithm.png)

## When to Use Backtracking?
- Problems requiring **exhaustive search** (e.g., permutations, subsets).
- Constraint satisfaction problems (e.g., Sudoku, N-Queens).
- Pathfinding and puzzle-solving (e.g., mazes, Knight's Tour).

---

## Example: N-Queens Problem in C#
The N-Queens problem requires placing `N` queens on an `N x N` chessboard such that no two queens attack each other. Below is a simplified C# implementation.

```csharp
using System;

class NQueens
{
    private int N;
    private int[,] board;

    public NQueens(int n)
    {
        N = n;
        board = new int[n, n];
    }

    public bool Solve()
    {
        return SolveUtil(0);
    }

    private bool SolveUtil(int col)
    {
        if (col >= N)
            return true;

        for (int i = 0; i < N; i++)
        {
            if (IsSafe(i, col))
            {
                board[i, col] = 1;
                if (SolveUtil(col + 1))
                    return true;
                board[i, col] = 0; // Backtrack
            }
        }
        return false;
    }

    private bool IsSafe(int row, int col)
    {
        // Check left side of current row
        for (int i = 0; i < col; i++)
            if (board[row, i] == 1)
                return false;

        // Check upper diagonal
        for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
            if (board[i, j] == 1)
                return false;

        // Check lower diagonal
        for (int i = row, j = col; i < N && j >= 0; i++, j--)
            if (board[i, j] == 1)
                return false;

        return true;
    }

    public void PrintSolution()
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
                Console.Write(board[i, j] + " ");
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        NQueens solver = new NQueens(4);
        if (solver.Solve())
            solver.PrintSolution();
        else
            Console.WriteLine("No solution exists.");
    }
}
```

### Common Backtracking Problems
 - Sudoku Solver
 - Subset Sum
 - Permutations and Combinations
 - Hamiltonian Path
 - Rat in a Maze


## Resources
1. GeeksforGeeks: Introduction to Backtracking
2. "The Algorithm Design Manual" by Steven S. Skiena



# Backtracking vs. Branch and Bound

## Introduction
**Backtracking** and **Branch and Bound** are algorithmic techniques used to solve problems by exploring potential solutions. While they share similarities, they differ in their approaches and applications.

### Backtrack
