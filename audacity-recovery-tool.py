import os

path = ""

def time_order(path):

    dir = path

    files_au = [file for file in os.listdir(dir) if file.endswith('.au')]

    files_order = sorted(files_au, key=lambda file: os.path.getmtime(os.path.join(dir, file)))

    for index, file in enumerate(files_order, start=1):
        new_name = f'file{index:05d}.au'
        actual_path = os.path.join(dir, file)
        new_path = os.path.join(dir, new_name)
        os.rename(actual_path, new_path)
        print(f'Renamed: {file} -> {new_name}')


def erase_odd(path):
    folder_path = path
    file_prefix = 'file'
    file_extension = '.au'

    for filename in os.listdir(folder_path):
        if filename.startswith(file_prefix) and filename.endswith(file_extension):
            file_number = int(filename[len(file_prefix):len(file_prefix) + 5])
            if file_number % 2 == 0:
                file_to_delete = os.path.join(folder_path, filename)
                os.remove(file_to_delete)
                print(f"Erased: {filename}")


if __name__ == "__main__":
    print("\033[91m\033[1m ---------------------------------- WARNING ----------------------------------")
    print("\033[0m\033[93m Is highly recommended to do a copy of the .au files before doing this process")
    print("\033[91m\033[1m -----------------------------------------------------------------------------")
    print("\n")
    print("\033[1m\033[36m ----------------------------------------- HOW TO USE -----------------------------------------")
    print("\033[0m\033[96m         Select the folder with ALL the .au files, it's posible that these files are in")
    print("\033[0m\033[96m separete folders, something like 'd00', 'd01', etc... Please, put all the files in one folder.")
    print("\033[0m\033[96m     Once the process has finished import all the files into audacity, select all the tracks")
    print("\033[0m\033[96m          with [CTRL+A] then go to 'Tracks > Align Tracks > Align End To End'. Enjoy!")
    print("\033[1m\033[36m ----------------------------------------------------------------------------------------------")
    print("\n\033[0m\033[1m")
    path = input("Folder > ")
    time_order(path)
    erase_odd(path)