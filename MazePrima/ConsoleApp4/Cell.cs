﻿using System.Collections.Generic;
using System.Linq;
using ConsoleApp4;

namespace mazeGenerator_dfs
{
    public struct Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsCell { get; set; }
        public bool IsVisited { get; set; }

        public static Result<Cell> Create(int x, int y, bool isVisited = false, bool isCell = true)
        {
            var errors = new List<string>();

            if (x < 0) { errors.Add("Параметр X должен быть больше 0"); };
            if (y < 0) { errors.Add("Параметр Y должен быть больше 0"); }

            if (errors.Any())
            {
                return Result<Cell>.Fail(errors);
            }

            return Result<Cell>.Success(new Cell(x, y, isVisited, isCell));
        }

        private Cell(int x, int y, bool isVisited = false, bool isCell = true)
        {
            X = x < 0 ? 0 : x;
            Y = y < 0 ? 0 : y;
            IsCell = isCell;
            IsVisited = isVisited;
        }
    }
}

