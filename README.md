# Features
- Random questions in a priority queue
- Starring of questions 
- Categories of questions
- Automatic category creation based on csv files in current directory
	- That is, every file should be its own category
	- If not possible, store data in a file so user doesn't continualy re-input

# Input
CSV File following this format:
```
Question,Answer,Open,Priority
Why did the chicken cross the road?,to get to the other side, yes, 9
9+10?,19,no,9
```

OR

Text file with the following format:
```
//Comments with // should be ignored
Why did the chicken cross the road?
	To get to the other side
	
Describe fopen:
	Opens a file
	
What's 11+10?
	*21 //* in ans field means question is not open
	
*Name the three macronutrients:
	Protein, fat, carbs
//*in Q field indicated priorty

**What makes up protein?
	Amino acids I think
//** indicates priority. * > ** > -
```