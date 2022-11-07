Modify first laboratory work
<ul>
    <li>Create some types of account with different
methods of rating calculating, e.g. standard account, account 
which loses 2x less points, account which gets additional
point for the winning some games in a row, etc. 
(minimum 2 types except standard account should be)</li>
    <li>Create different types of games. Base account must be
abstract and should contain general code for all types of
games and certain realisations should be. For example: 
standad game, training game without points losing, game in 
which only one user loses points. Minimum 3 types of games
should be</li>
    <li>Create a class which have functionality for returning
the game of any type by converting it to base type</li>
    <li>Modify methods WinGame() and LoseGame(). This 
methods should get a Game object instead of rating number. 
Game object should contain a method to calculate rating of 
the game</li>
    <li>Functionality from laboratory work 1 must be saved</li>
</ul>
TIP: logic and printing make in different methods. I.e 
printing methods shouldn`t contain any logic (e.g rating 
calculating, etc.) and the same for logic methods, they 
shouldn`t contain printing fuctions.
<br><br>=================================================<br><br>
Модифікувати першу лабораторну <br><br>
•Зробити декілька видів аккаунтів з різними методами 
нарахування балів. Наприклад: базовий аккаунт, аккаунт у 
якого знімається вдвічі менше балів, в якому нараховуються 
додаткові бали за серію перемог і тд. (мінімум 2 види крім 
базового)
•Зробити різни типи ігор. Базовий клас має бути абстрактним, 
містити код загальний для усіх ігор, та мають бути конкретні 
реалізації. Наприклад:
стандартна гра,
тренувальна без рейтингу
гра де на рейтинг грає лише один гравець
Мінімум 3 види <br>

•Зробити клас який буде містити в собі функціонал
для повернення гри будь якого типу, приводячи його до
базового типу гри.

•Модифікувати методи гравців WinGame та LoseGame щоб
замість рейтингу приходив об’єкт базової гри, що містить
метод\властивість для визначення на який рейтинг була гра.

•В результаті ви матимете базу гравців для кожного з яких
буде розраховуватися зміна рейтингу в залежності від типу
їх аккаунту та клас для генерації ігор різних типів на різний
рейтинг.

•Попередній функціонал має залишитись теж.

Примітка: Відділяйте методи виводу інформації від методів
що містять логіку. Тобто будь який метод що виводить
результати чи ще щось не має містити логіки (обрахунок
рейтингу, присвоєння результату гри та інше) і навпаки.