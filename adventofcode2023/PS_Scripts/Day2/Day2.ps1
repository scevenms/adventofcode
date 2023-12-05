#This script it to solve the adventofcode2023 day 1. 

$PuzzleRaw = Get-Content -Path .\Puzzle.txt
[int]$PuzzleAznwer = 0

#variables for what the staic data is.
[int]$red = 12
[int]$green = 13
[int]$blue = 14

$PuzzleRaw[1]

foreach ($line in $PuzzleRaw) {
    $line -match "Game (\d+):"
    $gameNumber = $matches[1]


    Write-Output $gameNumber

    
    $NumOfRed
    $NumOfGreen
    $NumOfBlue
}