Imports System.Windows.Forms
Public Class Form1
    Dim random As New Random()
    Dim randnum As New Integer
    Dim image1 As New Integer
    Dim image2 As New Integer
    Dim image3 As New Integer
    Dim username As String = InputBox("Enter your name")



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        randnum = random.Next(23)
        image1 = randnum
        If randnum = Nothing Then
            randnum = random.Next(23)
        End If
        PictureBox1.Image = My.Resources.ResourceManager.GetObject("image_" & randnum.ToString())

        If randnum = 1 Then
            TextBox1.Text = (username & " You are a chicken,Death is scaring you")
        ElseIf randnum = 2 Then
            TextBox1.Text = (username & " Inside you , you have the spirit to Conquer the World")
        ElseIf randnum = 3 Then
            TextBox1.Text = (username & " Hmm, I see, You know nothing (jon Snow) about Judgement")
        ElseIf randnum = 4 Then
            TextBox1.Text = (username & " I think that your future has no justice on you, you may die like this Tommorow")
        ElseIf randnum = 5 Then
            TextBox1.Text = (username & " Someone with HYPER-STRENGHT will kill you..Tonight at 9 am")
        ElseIf randnum = 6 Then
            TextBox1.Text = (username & " Your temperance is so low, i see that in 4 days you will follow
                             a treasure behind your street and you will die from a Ghost ")
        ElseIf randnum = 7 Then
            TextBox1.Text = (username & " Ahh, nothing to say on this.. Go and find a wife and stop messing with me ")
        ElseIf randnum = 8 Then
            TextBox1.Text = (username & " Haaaa, Devil is COMING FOR YOU, wait him tommorow around 8 am and COOK something")
        ElseIf randnum = 9 Then
            TextBox1.Text = (username & " Someone like him, NEVER BE ATTRACTED BY YOU")
        ElseIf randnum = 10 Then
            TextBox1.Text = (username & " Hmm, i see all people in your life they see you AS A FOOL HAHHAHA")
        ElseIf randnum = 11 Then
            TextBox1.Text = (username & " This man DIE FOR YOUR FREEDOM before 9.000 years, someone said that he saw him in the street near your
                             home, so be carefull tommorow")
        ElseIf randnum = 12 Then
            TextBox1.Text = (username & " You are going to be like him,nothing else to say ")
        ElseIf randnum = 13 Then
            TextBox1.Text = (username & " He is going to heal ALL YOUR TROOPS,so you need him if you go for a SIEGE,Call him")
        ElseIf randnum = 14 Then
            TextBox1.Text = (username & " In one week, a chick is gonna come to your house and drink wine with you
                             so go and Wash Yourself")
        ElseIf randnum = 15 Then
            TextBox1.Text = (username & " I see that you have no skills on this Section..so ........ Shame on you")
        ElseIf randnum = 16 Then
            TextBox1.Text = (username & " Another guy is gonna steal your gf, NOW,RUNNNNNN ")
        ElseIf randnum = 17 Then
            TextBox1.Text = (username & " Hmm..Something romantic? No...Werewolfs will come for you...be carefull..")
        ElseIf randnum = 18 Then
            TextBox1.Text = (username & " When the star explodes,your house will be burn,food for your mind,think!")
        ElseIf randnum = 19 Then
            TextBox1.Text = (username & " The sun is something good...your favorite person will die..be happy! Bye!")
        ElseIf randnum = 20 Then
            TextBox1.Text = (username & " The tower is something tall..So? I don't care , your life will be short...")
        ElseIf randnum = 21 Then
            TextBox1.Text = (username & " You will travel around the world and you will see people die every single minute..")
        ElseIf randnum = 22 Then
            TextBox1.Text = (username & " Hmm..so your life is like a russian rullete..with FULL GUN...you are condemned ")

        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        randnum = random.Next(22)
        While randnum = image1
            randnum = random.Next(23)
        End While
        image2 = randnum
        If randnum = Nothing Then
            randnum = random.Next(23)
        End If
        PictureBox2.Image = My.Resources.ResourceManager.GetObject("image_" & randnum.ToString())

        If randnum = 1 Then
            TextBox2.Text = (username & " You are a chicken,Death is scaring you")
        ElseIf randnum = 2 Then
            TextBox2.Text = (username & " Inside you , you have the spirit to Conquer the World")
        ElseIf randnum = 3 Then
            TextBox2.Text = (username & " Hmm, I see, You know nothing (jon Snow) about Judgement")
        ElseIf randnum = 4 Then
            TextBox2.Text = (username & " I think that your future has no justice on you, you may die like this Tommorow")
        ElseIf randnum = 5 Then
            TextBox2.Text = (username & " Someone with HYPER-STRENGHT will kill you..Tonight at 9 am")
        ElseIf randnum = 6 Then
            TextBox2.Text = (username & " Your temperance is so low, i see that in 4 days you will follow
                             a treasure behind your street and you will die from a Ghost ")
        ElseIf randnum = 7 Then
            TextBox2.Text = (username & " Ahh, nothing to say on this.. Go and find a wife and stop messing with me ")
        ElseIf randnum = 8 Then
            TextBox2.Text = (username & " Haaaa, Devil is COMING FOR YOU, wait him tommorow around 8 am and COOK something")
        ElseIf randnum = 9 Then
            TextBox2.Text = (username & " Someone like him, NEVER BE ATTRACTED BY YOU")
        ElseIf randnum = 10 Then
            TextBox2.Text = (username & " Hmm, i see all people in your life they see you AS A FOOL HAHHAHA")
        ElseIf randnum = 11 Then
            TextBox2.Text = (username & " This man DIE FOR YOUR FREEDOM before 9.000 years, someone said that he saw him in the street near your
                             home, so be carefull tommorow")
        ElseIf randnum = 12 Then
            TextBox2.Text = (username & " You are going to be like him,nothing else to say ")
        ElseIf randnum = 13 Then
            TextBox2.Text = (username & " He is going to heal ALL YOUR TROOPS,so you need him if you go for a SIEGE,Call him")
        ElseIf randnum = 14 Then
            TextBox2.Text = (username & " In one week, a chick is gonna come to your house and drink wine with you
                             so go and Wash Yourself")
        ElseIf randnum = 15 Then
            TextBox2.Text = (username & " I see that you have no skills on this Section..so ........ Shame on you")
        ElseIf randnum = 16 Then
            TextBox2.Text = (username & " Another guy is gonna steal your gf, NOW,RUNNNNNN ")
        ElseIf randnum = 17 Then
            TextBox2.Text = (username & " Hmm..Something romantic? No...Werewolfs will come for you...be carefull..")
        ElseIf randnum = 18 Then
            TextBox2.Text = (username & " When the star explodes,your house will be burn,food for your mind,think!")
        ElseIf randnum = 19 Then
            TextBox2.Text = (username & " The sun is something good...your favorite person will die..be happy! Bye!")
        ElseIf randnum = 20 Then
            TextBox2.Text = (username & " The tower is something tall..So? I don't care , your life will be short...")
        ElseIf randnum = 21 Then
            TextBox2.Text = (username & " You will travel around the world and you will see people die every single minute..")
        ElseIf randnum = 22 Then
            TextBox2.Text = (username & " Hmm..so your life is like a russian rullete..with FULL GUN...you are condemned ")

        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        randnum = random.Next(23)
        While randnum = image1 Or randnum = image2
            randnum = random.Next(23)
        End While
        image3 = randnum
        If randnum = Nothing Then
            randnum = random.Next(23)
        End If
        PictureBox3.Image = My.Resources.ResourceManager.GetObject("image_" & randnum.ToString())

        If randnum = 1 Then
            TextBox3.Text = (username & " You are a chicken,Death is scaring you")
        ElseIf randnum = 2 Then
            TextBox3.Text = (username & " Inside you , you have the spirit to Conquer the World")
        ElseIf randnum = 3 Then
            TextBox3.Text = (username & " Hmm, I see, You know nothing (jon Snow) about Judgement")
        ElseIf randnum = 4 Then
            TextBox3.Text = (username & " I think that your future has no justice on you, you may die like this Tommorow")
        ElseIf randnum = 5 Then
            TextBox3.Text = (username & " Someone with HYPER-STRENGHT will kill you..Tonight at 9 am")
        ElseIf randnum = 6 Then
            TextBox3.Text = (username & " Your temperance is so low, i see that in 4 days you will follow
                             a treasure behind your street and you will die from a Ghost ")
        ElseIf randnum = 7 Then
            TextBox3.Text = (username & " Ahh, nothing to say on this.. Go and find a wife and stop messing with me ")
        ElseIf randnum = 8 Then
            TextBox3.Text = (username & " Haaaa, Devil is COMING FOR YOU, wait him tommorow around 8 am and COOK something")
        ElseIf randnum = 9 Then
            TextBox3.Text = (username & " Someone like him, NEVER BE ATTRACTED BY YOU")
        ElseIf randnum = 10 Then
            TextBox3.Text = (username & " Hmm, i see all people in your life they see you AS A FOOL HAHHAHA")
        ElseIf randnum = 11 Then
            TextBox3.Text = (username & " This man DIE FOR YOUR FREEDOM before 9.000 years, someone said that he saw him in the street near your
                             home, so be carefull tommorow")
        ElseIf randnum = 12 Then
            TextBox3.Text = (username & " You are going to be like him,nothing else to say ")
        ElseIf randnum = 13 Then
            TextBox3.Text = (username & " He is going to heal ALL YOUR TROOPS,so you need him if you go for a SIEGE,Call him")
        ElseIf randnum = 14 Then
            TextBox3.Text = (username & " In one week, a chick is gonna come to your house and drink wine with you
                             so go and Wash Yourself")
        ElseIf randnum = 15 Then
            TextBox3.Text = (username & " I see that you have no skills on this Section..so ........ Shame on you")
        ElseIf randnum = 16 Then
            TextBox3.Text = (username & " Another guy is gonna steal your gf, NOW,RUNNNNNN ")
        ElseIf randnum = 17 Then
            TextBox3.Text = (username & " Hmm..Something romantic? No...Werewolfs will come for you...be carefull..")
        ElseIf randnum = 18 Then
            TextBox3.Text = (username & " When the star explodes,your house will be burn,food for your mind,think!")
        ElseIf randnum = 19 Then
            TextBox3.Text = (username & " The sun is something good...your favorite person will die..be happy! Bye!")
        ElseIf randnum = 20 Then
            TextBox3.Text = (username & " The tower is something tall..So? I don't care , your life will be short...")
        ElseIf randnum = 21 Then
            TextBox3.Text = (username & " You will travel around the world and you will see people die every single minute..")
        ElseIf randnum = 22 Then
            TextBox3.Text = (username & " Hmm..so your life is like a russian rullete..with FULL GUN...you are condemned ")

        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        randnum = random.Next(23)
        While randnum = image1 Or randnum = image2 Or randnum = image3
            randnum = random.Next(23)
        End While
        If randnum = Nothing Then
            randnum = random.Next(23)
        End If

        PictureBox4.Image = My.Resources.ResourceManager.GetObject("image_" & randnum.ToString())
        If randnum = 1 Then
            TextBox4.Text = (username & " You are a chicken,Death is scaring you")
        ElseIf randnum = 2 Then
            TextBox4.Text = (username & " Inside you , you have the spirit to Conquer the World")
        ElseIf randnum = 3 Then
            TextBox4.Text = (username & " Hmm, I see, You know nothing (jon Snow) about Judgement")
        ElseIf randnum = 4 Then
            TextBox4.Text = (username & " I think that your future has no justice on you, you may die like this Tommorow")
        ElseIf randnum = 5 Then
            TextBox4.Text = (username & " Someone with HYPER-STRENGHT will kill you..Tonight at 9 am")
        ElseIf randnum = 6 Then
            TextBox4.Text = (username & " Your temperance is so low, i see that in 4 days you will follow
                             a treasure behind your street and you will die from a Ghost ")
        ElseIf randnum = 7 Then
            TextBox4.Text = (username & " Ahh, nothing to say on this.. Go and find a wife and stop messing with me ")
        ElseIf randnum = 8 Then
            TextBox4.Text = (username & " Haaaa, Devil is COMING FOR YOU, wait him tommorow around 8 am and COOK something")
        ElseIf randnum = 9 Then
            TextBox4.Text = (username & " Someone like him, NEVER BE ATTRACTED BY YOU")
        ElseIf randnum = 10 Then
            TextBox4.Text = (username & " Hmm, i see all people in your life they see you AS A FOOL HAHHAHA")
        ElseIf randnum = 11 Then
            TextBox4.Text = (username & " This man DIE FOR YOUR FREEDOM before 9.000 years, someone said that he saw him in the street near your
                             home, so be carefull tommorow")
        ElseIf randnum = 12 Then
            TextBox4.Text = (username & " You are going to be like him,nothing else to say ")
        ElseIf randnum = 13 Then
            TextBox4.Text = (username & " He is going to heal ALL YOUR TROOPS,so you need him if you go for a SIEGE,Call him")
        ElseIf randnum = 14 Then
            TextBox4.Text = (username & " In one week, a chick is gonna come to your house and drink wine with you
                             so go and Wash Yourself")
        ElseIf randnum = 15 Then
            TextBox4.Text = (username & " I see that you have no skills on this Section..so ........ Shame on you")
        ElseIf randnum = 16 Then
            TextBox4.Text = (username & " Another guy is gonna steal your gf, NOW,RUNNNNNN ")
        ElseIf randnum = 17 Then
            TextBox4.Text = (username & " Hmm..Something romantic? No...Werewolfs will come for you...be carefull..")
        ElseIf randnum = 18 Then
            TextBox4.Text = (username & " When the star explodes,your house will be burn,food for your mind,think!")
        ElseIf randnum = 19 Then
            TextBox4.Text = (username & " The sun is something good...your favorite person will die..be happy! Bye!")
        ElseIf randnum = 20 Then
            TextBox4.Text = (username & " The tower is something tall..So? I don't care , your life will be short...")
        ElseIf randnum = 21 Then
            TextBox4.Text = (username & " You will travel around the world and you will see people die every single minute..")
        ElseIf randnum = 22 Then
            TextBox4.Text = (username & " Hmm..so your life is like a russian rullete..with FULL GUN...you are condemned ")

        End If
    End Sub


End Class



