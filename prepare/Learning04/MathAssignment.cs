using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // public MathAssignment() : base()
    // {
    //     _textbookSection = "Section 7.3";
    //     _problems = "Problems 8-19";
    // }

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;

    }


    public string GetHomeworkList()
    {
        return $@"Section {_textbookSection} - Problems {_problems}";
    }
}