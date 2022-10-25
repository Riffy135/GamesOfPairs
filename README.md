# GamesOfPairs
PROJECT DEVELOPED WITH NET MAUI/C#
ISSUE WITH BUTTON BACKGROUND NOT BEING UPDATED WHEN NEXT BUTTON PRESSED

I am not able to get the Next Button to correctly change the background color.

Usage:

When a button is clicked it should turn GRAY
When another button is clicked, if it matches the previous button, they should both turn GREEN, otherwise they should turn DARK-CYAN and an error message pops up
The user can continue matching buttons or click on NEXT button.
If Next clicked the 16 buttons' content is updated and the Background reset to DARK-GRAY.
I would also like to populate the Text values of the two Labels in ViewModel and enable them.

                <Label x:Name="CorrectCntName" Text="0" Grid.Row="0" Grid.Column="0" TextColor="White" HorizontalTextAlignment="Center" VerticalTextAlignment="Center"  BackgroundColor="Green"  FontSize="Large" IsVisible="{Binding IsCorrectCntVisible, Mode=TwoWay}"></Label>
                <Label x:Name="WrongCntName" Text="0" Grid.Row="0" Grid.Column="2" BackgroundColor="Red" TextColor="White" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" FontSize="Large" IsVisible="{Binding IsWrongCntVisible, Mode=TwoWay}"></Label>
Can you see where I am going wrong.

Thank you so much for your help.
