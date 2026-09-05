# Sean Elston - In class activites
## Devlogs
### W1
### Question 1
...
int x = 2;
x *= 5;

X = 5
...

### Question 2 
...
int x = 0;
for(int i = 0; i < 2; i++)
{
    x += 1;
}


X = 2
...

### Question 3
...

private void Update () {
    PrintMessage();
}
    private void PrintMessage () {
        Debug.Log(“hello world”);
}

Update is a public function that runs every frame within unity
Private void Print message is a custom function that will run the code within it when called
Debug.log adds a debug log, with the written text

All together the script will print helloworlds 
...

### Question 4
...
public class Example : ??? {
    private void Update () {
        PrintMessage();
    }
    private void PrintMessage () {
        Debug.Log(“hello world”);
    }
}

??? = Monobehaviour
...

### Question 5
...
private void Start () {
    PrintMessage(10);
}
    private void PrintMessage (int x) {
        Debug.Log(“x = ” + x);
}

When this script runs it will run the PrintMessage function, which will take an int as an input and print that int formatted with X = int

In this case since the input is PrintMessage(10); It will print X = 10
...

### Question 6
...
private void Start () {
    PrintMessage(10);
}
    private void PrintMessage (int x) {
        Debug.Log(“x = ” + x);
}

The pupose of (10) is the input for the custom  function PrintMessage,
The purpose of ("x =" + x) is to print the characters "X =" as text and then print X which comes from the input of the function
...

### Question 7
...
public class Example : MonoBehaviour {
    public Transform _playerTransform;
    public Vector3 _direction;
    private void Update () {
        Transform.Translate(_direction);
    }
}

This script will transform in a direction but with no speed so It will not move.
...

### Question 8
...
public class Example : MonoBehaviour {
    public Transform _playerTransform;
    public Vector3 _direction;
    private void Update () {
        Transform.Translate(_direction);
    }
}

should be changed to "transform.translate(_direction);
...
