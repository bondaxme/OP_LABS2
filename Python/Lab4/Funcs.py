import random
from TDate import TDate
from TTime import TTime


def DatesGenerate():
    dates = []
    n = int(input("Enter the amount of dates: "))
    for i in range(n):
        day = random.randint(1, 31)
        month = random.randint(1, 12)
        year = random.randint(0, 100)
        date = TDate(day, month, year)
        dates.append(date)
    return dates

def TimesGenerate():
    times = []
    n = int(input("Enter the amount of times: "))
    for i in range(n):
        hours = random.randint(0, 24)
        minutes = random.randint(0, 60)
        seconds = random.randint(0, 60)
        time = TTime(hours, minutes, seconds)
        times.append(time)
    return times

def ListOutput(list):
    for obj in list:
        obj.Output()

def IsLikeTime(date):
    if date.Number1 < 24 and date.Number3 < 60:
        return True
    return False

def ChangeDates(dates):
    for date in dates:
        if not IsLikeTime(date):
            date.DecreaseNumber1(5)

def ChangeTimes(times):
    for time in times:
        time.IncreaseNumber2(15)

def ChangeFormat(n):
    n_str = str(n)
    if n < 10:
        n_str = "0" + n_str
    return n_str

def DatesLikeTime(dates):
    dates_like_time = []
    for date in dates:
        if IsLikeTime(date):
            dates_like_time.append(date)
    return dates_like_time

