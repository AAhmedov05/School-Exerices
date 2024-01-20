int xCordinat = 0;
int yCordinat = 0;
int result = 0;
int nextRow;
int[,] array = {
	{0,7,0,0,0,0 },
	{0,3,8,0,0,0 },
	{0,8,1,0,0,0 },
	{0,2,7,4,4,0 },
	{0,4,5,2,6,5 },
};

while (yCordinat<5)
{
	if (yCordinat==0)
	{
		for (int c = 0; c < 6; c++)
		{
			if (array[0,c]!=0)
			{
				result += array[0, c];
				xCordinat= c;
				yCordinat++;
			}
		}
	}
	else
	{
		for (int r = 1; r < 5; r++)
		{
			nextRow = array[r, xCordinat - 1];
			if (nextRow > array[r, xCordinat + 1])
			{
				result += nextRow;
				xCordinat -= 1;
                yCordinat++;
            }
			else 
			{
				result += array[r, xCordinat + 1];
                xCordinat += 1;
                yCordinat++;
            }
			
		}
	}
}
Console.WriteLine($"Result: {result}");