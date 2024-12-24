using Tercia.Pages;

namespace Tercia;

public partial class TheoryPage
{
    public TheoryPage()
    {
        InitializeComponent();
    }
    
    private async void OnAccordsSectionClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TheorySectionPage("Аккорды — это группы из нескольких нот, которые звучат одновременно. Основные аккорды включают мажорные и минорные, которые отличаются третьими интервалами между нотами. Мажорные аккорды имеют яркое, «светлое» звучание, а минорные — более «темное». Существуют и более сложные аккорды, например, септаккорды, которые добавляют седьмую ноту к основному трезвучию. Прогрессии аккордов — это последовательности аккордов, которые используются для создания гармонии в музыке. Например, классическая прогрессия I-IV-V-I (мажорные аккорды на первой, четвертой и пятой ступенях) используется во многих музыкальных произведениях. Понимание аккордов и их прогрессий помогает определить гармоническую структуру произведения."));
    }

    private async void OnTempSectionClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TheorySectionPage("Ритм — это структура времени в музыке, которая определяется длительностями нот и пауз. Ритм помогает организовать музыкальные элементы в последовательность, при этом создавая ощущение движения и времени. Например, в 4/4 размере один такт состоит из четырех ударов, и каждая длительность может быть разделена на более мелкие единицы. Темп — это скорость, с которой исполняется музыкальное произведение, и измеряется в ударах в минуту (BPM). Чем выше темп, тем быстрее звучит произведение. Важными аспектами ритма являются акценты, которые определяют, какие ноты звучат сильнее в определенных моментах. Ритмическая структура играет ключевую роль в создании динамики и настроения музыки."));
    }

    private async void OnTonalitySectionClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TheorySectionPage("Тональность — это система, в которой музыкальные произведения строятся вокруг основной ноты (тоники), и определяет, какие звуки и аккорды будут использоваться в произведении. Тональность указывает на набор звуков (ступеней) и аккордов, которые будут доминировать в композиции. В большинстве случаев, если произведение написано в мажорной тональности, то его основная гамма состоит из последовательности из 7 звуков с определенными интервалами (например, в до-мажоре: до, ре, ми, фа, соль, ля, си). Минорные тональности имеют другую последовательность интервалов, что придает музыке более меланхоличный или задумчивый оттенок."));
    }

    private async void OnNotesPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NotesPage());
    }

    private async void OnCoursesPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CoursesPage());
    }

    private async void OnTheoryPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TheoryPage());
    }

    private async void OnMetronomePageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MetronomePage());
    }
}