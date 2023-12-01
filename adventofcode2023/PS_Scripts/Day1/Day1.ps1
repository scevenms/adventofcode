#This script it to solve the adventofcode2023 day 1. 

$PuzzleRaw = Get-Content -Path .\Puzzle.txt
[int]$PuzzleAznwer = 0
foreach ($line in $PuzzleRaw) {
    Write-Host "Processing $line"
    $numbers = $line -replace "\D", ""
    $firstNumber = $numbers[0]
    $lastNumber = $numbers[-1]
    Write-Host "Answer for this line is $firstNumber$lastNumber"
    $PuzzleAznwer += [int]"$firstNumber$lastNumber"
    $PuzzleAznwer
}
Write-Host $PuzzleAznwer
$PuzzleAznwer | Out-File -FilePath .\Answer.txt