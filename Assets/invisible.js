#pragma strict

function Start () {

}

function Update () {

}


/*function OnBecameInvisible () 
{
	transform.Translate(renderer.bounds.size.x * 3, 0, 0);
	
	if(Random.Range(0, 1) == 1)
	{
	
	}
	
    print("Invisible");
}*/

function OnBecameInvisible () 
{
	transform.Translate(renderer.bounds.size.x * 3, 0, 0);
    print("Invisible");
}

