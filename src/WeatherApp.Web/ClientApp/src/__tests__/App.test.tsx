import { describe, it, expect } from 'vitest';
import { render, screen } from '@testing-library/react';
import App from "../App.tsx";

describe('renders learn react link', () => {
  it("should be rendered", () => {
    render(<App />);
    const linkElement = screen.queryByText(/learn react/i);
    expect(linkElement).not.toBeNull()
  })
})