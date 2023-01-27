 public void GenerateRandomsNumberWithoutRepeat(int size)
    {
        int[] temp = new int[size];
        for (int i = 0; i < size; i++)
        {
            temp[i] = Random.Range(1, size+1);
            for (int j = 1; j <= i; j++)
            {
                while(temp[i] == temp[j-1])
                {
                    temp[i] = Random.Range(1, size+1);
                    j = 1;
                }
            }
        }
        for (int i = 0; i < size; i++)
            Debug.Log(temp[i]);
    }
