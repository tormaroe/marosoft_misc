require 'gosu'

def main
	grid = Grid.new 200, 100
	window = AntWindow.new grid
	window.show
end

class AntWindow < Gosu::Window
	# The magic number '2' is the size of each cell (duplicated for performance reasons)
	def initialize grid
		@grid = grid
		super @grid.width * 2, @grid.height * 2, false
		self.caption = "Langton's Ant"
		@counter = 0

		@white = Gosu::Image.new(self, "white.png", true)
		@red   = Gosu::Image.new(self, "red.png",   true)

		@time = Time.now
	end
	def update
		@grid.ant.move
		@counter += 1
		if @counter % 100 == 0
			puts "#{@counter} steps completed in #{Time.now - @time} seconds"
		 	@time = Time.now	
		end
	rescue
		puts "The End"
	end
	def draw
		@grid.cells.each do |cell|
			@white.draw(
				cell.pos.width * 2, 
				cell.pos.height * 2, 
				0) if cell.color == :white
		end
		@red.draw(@grid.ant.pos.width * 2, @grid.ant.pos.height * 2, 0)
	end
end

class Pos < Struct.new(:width, :height); end

class Cell < Struct.new(:pos, :color); end

class Grid
	attr_reader :width, :height, :ant, :cells
	def initialize width, height
		@width, @height = width, height
		initialize_cells
		initialize_ant
	end
	def initialize_cells
		@cells = []
		for i in 1..@height do
			for j in 1..@width do
				@cells <<  Cell.new(Pos.new(j, i), :black)
			end
		end
	end
	def initialize_ant
		@ant = Ant.new(
			:pos => Pos.new(@width / 2, @height / 2), 
			:direction => :north, 
			:grid => self
		)
	end
	def white? pos
		@cells[index_for_pos(pos)].color == :white
	end
	def flip pos
		c = @cells[index_for_pos(pos)]
		c.color = c.color == :black ? :white : :black 
	end
	def index_for_pos pos
		(@width * (pos.height-1)) + pos.width
	end
end

class Ant
	attr_accessor :pos, :direction, :grid
	def initialize args
		@pos = args[:pos]
		@direction = args[:direction]
		@grid = args[:grid]
		@legs = TurnHelper.new
	end
	def move
		turn = @grid.white?(@pos) ? :turn_right : :turn_left
		@grid.flip(@pos)
		send turn
		move_forward
	end
	def turn_right
		@direction = @legs.move @direction, :right
	end
	def turn_left
		@direction = @legs.move @direction, :left
	end
	def move_forward
		case @direction
		when :north
			@pos.height -= 1
		when :east
			@pos.width += 1
		when :south
			@pos.height += 1
		when :west
			@pos.width -= 1 
		else
			raise "Bad direction #{@direction}"
		end
	end
end

class TurnHelper
	DIRECTIONS = [:north, :east, :south, :west]
	def move current_direction, direction_to_move
		i = DIRECTIONS.index(current_direction)
		i = self.send(direction_to_move, i)
		DIRECTIONS[i]
	end
	private
	def right i
		i = i + 1
		i = 0 if i >= DIRECTIONS.length
		return i
	end
	def left i
		i = i - 1
		i = DIRECTIONS.length - 1 if i < 0
		return i
	end
end

main
