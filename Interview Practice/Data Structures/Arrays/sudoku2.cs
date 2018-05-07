bool sudoku2(char[][] grid) {
    
    for(int i = 0;i<9;i++)
    {
        List<int> rowValue = new List<int>();
        bool rowCheck = true;
        for(int j = 0;j<9;j++)
        {
            if(grid[i][j] != '.')
            {
                if(rowValue.Contains(Convert.ToInt32(grid[i][j])))
                {
                    rowCheck = false;
                }
                else
                {
                    rowValue.Add(Convert.ToInt32(grid[i][j]));
                }
            }            
        }
        if(rowCheck == false)
        {
            Console.WriteLine("rowCheck");
            return false;
        }
    }
    
    
     for(int i = 0;i<9;i++)
     {
         List<int> colValue = new List<int>();
         bool colCheck = true;
         for(int j = 0;j<9;j++)
         {
             if(grid[j][i] != '.')
             {
                 if(colValue.Contains(Convert.ToInt32(grid[j][i])))
                 {
                     colCheck = false;
                 }
                 else
                 {
                     colValue.Add(Convert.ToInt32(grid[j][i]));
                 }
             }
         }
         if(colCheck == false)
         {
             Console.WriteLine("colCheck");
             return false;
         }
     }
    
    for(int i = 0; i < 3;i++ )
    {
        for(int j = 0; j < 3;j++ )
        {
            List<int> cellValue = new List<int>();
            bool cellCheck = true;
            
            for(int rowCount = i*3; rowCount < (i*3) + 3; rowCount++ )
            {
                for(int colCount = j*3; colCount < (j*3)+3;colCount++)
                {
                    if(grid[rowCount][colCount] != '.')
                    {
                        if(cellValue.Contains(Convert.ToInt32(grid[rowCount][colCount])))
                        {
                            cellCheck = false;
                        }
                        else
                        {
                            cellValue.Add(Convert.ToInt32(grid[rowCount][colCount]));
                        }
                    }
                }
            }
            
            if(cellCheck == false)
            {
                Console.WriteLine("cellCheck +" +i.ToString()+ " "+j.ToString());
                return false;
            }
            
            
        }
        
       
    }
    return true;
}
