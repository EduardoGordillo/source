""""libreria de fibonacci """
import sys
def fibonacci_method(j):
    """metodo fibonacci python"""
    if j == 0:
        return 0
    if j <= 1:
        return 1
    return fibonacci_method(j-1) + fibonacci_method(j-2)
def main():
    """main method"""
    print(fibonacci_method(500))
if __name__ == "__main__":
    sys.exit(int(main() or 0))
