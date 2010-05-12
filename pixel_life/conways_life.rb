require 'pixel_life'

def main
	width, height = 200, 100
	grid = Grid.new width, height

	life = Conway.new grid
	life.randomize :cells => 1_000

	window = PixelWindow.new "Conway's Life", grid
	window.on_update = lambda{ life.tick }
	window.show
end

class Conway
	def initialize grid
		@grid = grid
	end
	def randomize args
		max_width = @grid.width
		max_height = @grid.height
		args[:cells].times { @grid.flip random_pos(max_width, max_height) }
	end
	def random_pos max_width, max_height
		Pos.new rand(max_width), rand(max_height)
	end
	def tick
		@grid.cells.each {|cell| cell.evaluate_transition(@grid) }
		@grid.cells.each {|cell| cell.perform_transition }
	end
end

class Cell # Extending the cell class
	def evaluate_transition grid
		live_neighbours = grid.get_neighbours_of(self).live_count
		if alive?
			@should_be_alive = (live_neighbours == 2 or live_neighbours == 3)
		else
			@should_be_alive = (live_neighbours == 3)
		end
	end
	def alive?
		self.color == :white
	end
	def perform_transition
		self.color = @should_be_alive ? :white : :black
	end
end

class Grid # Extending the grid class
	def get_neighbours_of cell
		same_height = cell.pos.height
		up = same_height - 1
		down = same_height + 1
		same_width = cell.pos.width
		left = same_width - 1
		right = same_width + 1

		neighbours = []
		neighbours << @cells[index_for_pos(Pos.new(left, up))]
		neighbours << @cells[index_for_pos(Pos.new(left, same_height))]
		neighbours << @cells[index_for_pos(Pos.new(left, down))]
		neighbours << @cells[index_for_pos(Pos.new(same_width, up))]
		neighbours << @cells[index_for_pos(Pos.new(same_width, down))]
		neighbours << @cells[index_for_pos(Pos.new(right, up))]
		neighbours << @cells[index_for_pos(Pos.new(right, same_height))]
		neighbours << @cells[index_for_pos(Pos.new(right, down))]
		return neighbours
	end
end

class Array
	def live_count
		self.inject(0) do |acc, cell|
			acc + ((cell and cell.alive?) ? 1 : 0)
		end
	end
end

main # starts the program
