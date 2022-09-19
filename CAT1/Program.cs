SayHello();


static void SayHello()
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine(freqCnt(new List<string> { "test", "qa", "test", "dev", "prod" }));
}


// Counts the amount of times a string is found in the list
// param: data, List of strings
// returns: Dictionary with the data frequency on each row 
static Dictionary<String, Int32> freqCnt(List<String> data) {
    Dictionary<String, Int32> result = new Dictionary<String, Int32>();
    for (Int32 i = 0; i < data.Count; i++) {
        if (result.ContainsKey(data[i]))
        {
            Int32 value = 0;
            result.TryGetValue(data[i], out value);
            result.Remove(data[i]); // -- otherwise an exception on the next line?!?
            result.Add(data[i], value + 1);
        } 
        else
            result.Add(data[i], 1);
    }
    return result;
}

// Generics implementation for counts the amount of times a string is found in the list
// param: data, Generic list of strings
// returns: Dictionary with the data frequency on each row 
static Dictionary<string, int> FrequencyCount<S>(IEnumerable<string> data)
{
	var result = new Dictionary<string, int>();
	foreach (var word in data)
	{
		if (result.ContainsKey(word))
		{
			result[word] = result[word] + 1;
		}
		else
		{
			result[word] = 1;
		}
	}

	return result;
}