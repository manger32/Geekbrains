// Модальное окно
// alert("Hi");
let test = parseInt(prompt("Введите, сколько Вам лет:"));
let right = confirm("Вы хотите получать уведомления?");
if (test < 15 && test > 10)
{
	alert("Вам " + test + " лет");
}
else if (test % 10 == 1)
{
	alert("Вам " + test + " год");
}
else if (test % 10 == 2 || test % 10 == 3 || test % 10 == 4)
{
	alert("Вам " + test + " года");
}
else
{
	alert("Вам " + test + " лет");
}

let accessAllowed = (test >= 18) ? true : false;

if (!accessAllowed)
	window.close();

//let x = 1;
//alert(+x);

/**
let a = 1;
switch (a)
{
	case 1:
		alert("yes");
		break;
	case 2:
		alert("no");
		break;
	default:
		alert("no such values");
}

function showMessage(a, b)
{
	alert("Hi everybody");
	return a + b;
}
let a = parseInt(prompt("Input a"));
let b = parseInt(prompt("Input b"));
showMessage(a,b)	
**/