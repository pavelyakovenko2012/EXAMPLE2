int [] array = {14,23,58,13,46,58,56,79,98};


int n = array.Length;
int find = 58;

int index = 0;

while (index < n)
{
    
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index = index +1;
}